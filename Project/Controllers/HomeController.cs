using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;
//extra
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using  Microsoft.AspNetCore.Server.Kestrel.Core;

//extra probably for sessions
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        protected readonly IWebHostEnvironment hostingEnvironment;
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context, IWebHostEnvironment environment)
        {
            _context = context;
            hostingEnvironment = environment;
        }

        protected string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                    + "_"
                    + Guid.NewGuid().ToString().Substring(0,4)
                    + Path.GetExtension(fileName);
        }
        //index page has both registration and login
        [HttpGet("")] //basically like combining get actions for 
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/index2")] //basically like combining get actions for 
        public IActionResult Index2()
        {
            return View();
        }

        //Post to registration
        [HttpPost("Registration")]
        public IActionResult Registration(User user)
        {
            // Check initial ModelState
            if (ModelState.IsValid)
            {
                // If a User exists with provided email
                if (_context.Users.Any(u => u.Email == user.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");

                    // You may consider returning to the View at this point
                    return View("Index");
                }
                // if everything is okay save the user to the DB
                // Initializing a PasswordHasher object, providing our User class as its type
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _context.Add(user);
                _context.SaveChanges();
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == user.Email);
                HttpContext.Session.SetInt32("userId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            // other code
            return View("Index");
        }

        //Post to login
        [HttpPost("LoginPost")] //try changing to /login
        public IActionResult LoginPost(Login userSubmission)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
                //ViewBag.ThisUser = userInDb; //CHECKKK
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<Login>();

                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("Password", "Invalid Password");
                    return View("Login");
                }
                // assign user ID to sessions
                HttpContext.Session.SetInt32("userId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            // go back to login if fails
            return View("Index");
        }

        //Get Dashboard
        [HttpGet("Dashboard")]
         public IActionResult Dashboard()
            {
                if (HttpContext.Session.GetInt32("userId") == null)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.AllReservations = _context.Reservations; //check later 
                ViewBag.UserId = (int)HttpContext.Session.GetInt32("userId");
                return View("Dashboard");
             

            }
         //Show add reservation
        [HttpGet("ReservationAdd")]
        public IActionResult ReservationAdd()
            {
                if (HttpContext.Session.GetInt32("userId") == null)
                {
                    return RedirectToAction("Index");
                }
                return View("ReservationAdd");
            }
    

        //Post to AddReservation
        [HttpPost("AddReservationPost")]
        public IActionResult AddReservationPost(Reservation newReservation)
            {   
               if (ModelState.IsValid)
                {
                    newReservation.UserId = (int)HttpContext.Session.GetInt32("userId");
                    _context.Add(newReservation);
                    _context.SaveChanges();
                    Reservation thisReservation = _context.Reservations.OrderByDescending(w => w.CreatedAt).FirstOrDefault();
                    return Redirect("/SingleReservation/"+thisReservation.ReservationId);

                }

                return View("AddReservation", newReservation);
            }
            
        
        //Get single reservation info
        [HttpGet("SingleReservation/{rsvID}")]
        public IActionResult SingleReservation(int rsvID)
            {
                // get the selected Reservation info
                ViewBag.SpecificReservation = _context.Reservations
                    .FirstOrDefault(w => w.ReservationId == rsvID);

        
            return View("SingleReservation");
            }
       
        
        //Delete
        [HttpGet("delete/{ReservationId}")]
        public IActionResult DeleteReservation(int ReservationId)
            {
                // find the Reservation want to delete 
                Reservation RetrievedReservation = _context.Reservations
                    .FirstOrDefault(wed => wed.ReservationId == ReservationId);
                _context.Reservations.Remove(RetrievedReservation);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");

            }
        [HttpGet("/photos")]
        public IActionResult Gallery()
        {
            int userid = (int)HttpContext.Session.GetInt32("userId");
            //ViewBag.Photos = _context.Pictures.Where(pic => pic.userId == userid);
            ViewBag.Photos = _context.Pictures;
            return View();
        }
        [HttpGet("/likedphotos")]
        public IActionResult LikedPictures()
        {
            int userid = (int)HttpContext.Session.GetInt32("userId");
            ViewBag.LikedPhotos = _context.Associations
                .Include(pic => pic.picture)
                .Where(assoc => assoc.UserId == userid);
            //ViewBag.LikedPhotos = _context.Pictures.Include(pic => pic.usersWhoLikedThisPic).Where(user => user.UserId == userid);

           // var t = _context.Users
                // .Include(pic => pic.userLikedPics)
                // .ThenInclude(fave => fave.picture)
                // .FirstOrDefault(user => user.UserId == userid);
            return View();
        }

        [HttpGet("/photo/add")]
        public IActionResult AddPhoto()  
        {  
             if (HttpContext.Session.GetInt32("userId") == null)
                {
                    return RedirectToAction("Dashboard");
                }
                return View("AddPhoto");
        } 

    
    [HttpPost("/photo/add")]  
      public IActionResult AddPhoto(Picture picture)  
      {  
          if (ModelState.IsValid)
                {
                    picture.userId = (int)HttpContext.Session.GetInt32("userId");
                    var uniqueFileName = GetUniqueFileName(picture.Image.FileName);
                    var uploads = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/picture"); //Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploads,uniqueFileName);
                    picture.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                    picture.Name = uniqueFileName;
                    picture.Likes = 0;
                    _context.Add(picture);
                    _context.SaveChanges(); // chages are not saved until you request it.
                }

                return RedirectToAction("Gallery"); //find way to view all pictures
      }

        [HttpGet("picture/like/{PictureId}")]
        public IActionResult LikePicture(int PictureId)
        {
            Association likedPic = new Association();
            likedPic.UserId = (int)HttpContext.Session.GetInt32("userId");
            likedPic.picture = _context.Pictures.FirstOrDefault(pic => pic.PictureId == PictureId);
            likedPic.PictureId = PictureId;
            //likedPic.picture = _context.Pictures.FirstOrDefault(pic => pic.PictureId == picId);
            likedPic.picture.Likes++;
            _context.Associations.Add(likedPic);
            _context.SaveChanges();
            return RedirectToAction("Gallery");

        }
   
            
        
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
      
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
}
}

