function returnOddsArray1to255() {
    // create empty array
    // setup for loop, with max iterations
    // { add # to array }
    // return array
}
//ANSWER: before the for loop, create an index variable and set to 0
//In the for loop, start at 1 and increment by 2. Add the number to 
//arr[index] an increment index by 1

function returnArrayCountGreaterThanY(arr, y) {
        var numGreater = 0;
        for (var idx = 0;idx < arr.length;idx++){
            if (arr[idx] > y) { numGreater++; }
        }
        console.log("%d values greater than %d", numGreater, y);
}

function printMaxMinAverageArrayVals(arr)
{
    if (arr.length == 0) {
        console.log("[] arr, no min/max/avg");
        return;
    }
    var min = arr[0];
    var max = arr[0];
    var sum = arr[0];
    for (var idx=1; idx < arr.length;idx++){
        if (arr[idx] < min) { min = arr[idx]; }
        if (arr[idx] > max) { max = arr[idx]; }
        sum += arr[idx];
    }
    console.log("Max val:", max);
    console.log("Min val:", min);
    console.log("Avg val:", sum/arr.length);
    return [max, min, sum/arr.length];
}