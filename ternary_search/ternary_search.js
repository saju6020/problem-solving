function ternary_search(left, right, key, arr) {
    while (right >= left) {
        var mid1 = left + Math.round((right - left) / 3);
        var mid2 = right - Math.round((right - left) / 3);
        console.log("left:" + mid1 + " right:" + mid2);
        if (key === arr[mid1]) {
            return mid1;
        }
        if (key === arr[mid2]) {
            return mid2;
        }
        if (key < arr[mid1]) {
            right = mid1 - 1;
        }
        else if (key > arr[mid2]) {
            left = mid2 + 1;
        }
        else {
            left = mid1 + 1;
            right = mid2 - 1;
        }
    }
    return -1;
}
var arr = [1, 2, 3, 7, 8, 10, 14, 16, 17, 25, 50];
console.log(ternary_search(0, 10, 25, arr));
