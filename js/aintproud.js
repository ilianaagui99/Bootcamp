function returnOddsArray1to255() {
        var oddArray = [];
        for (var num = 1; num <= 255; num += 2) {
            oddArray.push(num);
        }
        return oddArray;
} 

function numGreaterThanY(arr, y) {
        var numGtr=0;
        for (var idx=0; idx<arr.length; idx++) {
            if(arr[idx]> y) { numGtr ++;}
        }
        console.log("%d > %d",numGtr,y);
        return numGtr;
}

function squareArrVals(arr)
{
    for ( var idx = 0;idx<arr.length; idx++)
    {
        arr[idx] = arr[idx] * arr[idx];
    }
    
    return arr;
}

function zeroOutArrNegativeVals(arr)
{
    for ( var idx = 0; idx < arr.length; idx++) {
        if (arr[idx ]< 0)
        { arr[idx] = 0; }
    }
    return arr;
}

function shiftArrayValsLeft(arr) {
        for(var idx=1;idx<arr.length; idx++) {
            arr[idx - 1] = arr[idx];
        }
        arr[arr.length-1] = 0;
        return arr;
}

function sswapStrForArrNegVals(arr){
        for (var idx = 0; idx<arr.length; idx++) {
        if(arr[idx] < 0) { arr[idx]="Dojo" }
        }
        return arr;
}