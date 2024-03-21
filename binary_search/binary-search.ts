function binary_search(arr: number[], key: number): number {

    let mid: number = Math.round((arr.length-1) / 2);
    let startIndex: number = 0;
    let endIndex: number = arr.length-1;

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

let inputArray:number[] = [1,2,10,12,15,20,25]

let index = binary_search(inputArray, 2);
console.log(index);
