function returnOddsArray1to255() {
    var oddArray = [];
    for (var num = 1; num <= 255; num += 2) {
        oddArray.push(num);
    }
    return oddArray;
} 

function returnArrayCountGreaterThanY(arr, y) {
    var numGreater = 0;
    for (var idx = 0; idx < arr.length; idx++) {
        if (arr[idx]>y) { numGreater ++; }
    }
    console.log("%d are larger than %d", numGreater, y);
}

function printMaxMinAverageArrayVals(arr) {
        if (arr.length == 0) {
            console.log("[], no min/max/avg");
            return;
        }
        var min = arr[0], max = arr[0];
        var sum = arr[0];
        for(var idx = 1; idx < arr.length; idx++) {
            if (arr[idx] < min) { min = arr[idx]; }
            if (arr[idx] > max) { max = arr[idx]; }
            sum += arr[idx];
        }
        console.log("Max value:", max);
        console.log("Min value:", min);
        console.log("Avg:",sum/arr.length);
    }