function returnOddsArray1to255() {
        var oddArray = [];
        var i = 0;
        for (var num=1;num<=255; num+=2){ 
          oddArray[i] = num;
          i++;
        }
}

function countGreaterThanY(arr, y) {
        var numGreater = 0;
        for(var idx = 0; idx < arr.length; idx++) {
            if (arr[idx] > y)
            { numGreater++; }
        }
        return numGreater;
}

function printMaxMinAverage(arr) {
        if (arr.length == 0) { return; }
        var min = arr[0];
        var max = arr[0];
        var sum = arr[0];
        for (var idx = 1; idx < arr.length; idx++) {
            if (arr[idx] < min)
            { min = arr[idx]; }
            if (arr[idx] > max)
            { max = arr[idx]; }
            sum += arr[idx];
        }
       var avg = sum/arr.length;
       console.log("min: "+ min + " max: " + max + " avg: "+  avg);
}

function squareArrVals(arr) {
        for ( var idx = 0; idx < arr.length; idx++){
            arr[idx] = arr[idx] * arr[idx];
        }
}  

function zeroOutArrayNegativeVals(arr) {
        for ( var idx=0; idx<arr.length;idx++) {
            if (arr[idx]<0) { arr[idx]=0; }
        }
        for ( var idx=0; idx<arr.length;idx++) {
            console.log(arr[idx]);
        }
}

function shiftArrayValsLeft(arr) {
        for(var ix=1;ix<arr.length; ix++) {
            arr[ix - 1] = arr[ix];
        }
        arr[arr.length-1] = 0;
        return arr;
}

function swapStringForArrNegs(arr){
        for (var idx = 0; idx<arr.length; idx++) {
        if(arr[idx] < 0) { arr[idx]="Dojo" }
        }
        return arr;
}
    
    
    