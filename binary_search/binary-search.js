function binary_search(arr, key) {
    var mid = Math.round((arr.length - 1) / 2);
    var startIndex = 0;
    var endIndex = arr.length - 1;
    while (mid <= endIndex) {
        if (key === arr[mid]) {
            return mid;
        }
        else if (key > arr[mid]) {
            startIndex = mid + 1;
        }
        else {
            endIndex = mid - 1;
        }
        mid = Math.round((endIndex + startIndex) / 2);
    }
}
var inputArray = [1, 2, 10, 12, 15, 20, 25];
var index = binary_search(inputArray, 2);
console.log(index);
