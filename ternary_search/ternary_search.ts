
function ternary_search(left:number, right:number, key:number, arr:number[]):number
{
    while(right >=left)
    {
        let mid1:number = left + Math.round((right-left)/3);
        let mid2:number = right - Math.round((right-left)/3);

        console.log(`left:${mid1} right:${mid2}`)

        if(key === arr[mid1])
        {
            return mid1;
        }

        if(key === arr[mid2])
        {
            return mid2;
        }

        if(key < arr[mid1])
        {
            right = mid1 - 1;
        }
        else if(key > arr[mid2])
        {
           left = mid2 + 1;
        }
        else
        {
            left = mid1 + 1;
            right = mid2 - 1;
        }
    }

    return -1;
}

let arr:number[] = [1,2,3,7,8,10,14,16,17,25,50];

console.log(ternary_search(0,10,25,arr));