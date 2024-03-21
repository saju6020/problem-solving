function getBinaryNumber(num:number) : number[]
{
    let output:number[] = [];
    
    while(num >=1 )
    {
        let binary_bit:number = num % 2;                
        output.push(binary_bit);
        num = Math.floor(num / 2);        
    }

    return output;
}

let binaryArray = getBinaryNumber(439);

let tempConsecutiveOnes:number = 0;
let consecutiveOnes:number = 0;

let strOutput:string='';
for(let index:number = binaryArray.length -1; index >=0; index--)
{
   // console.log(binaryArray[index]);

    if(binaryArray[index] === 1)
    {
        consecutiveOnes++;
    }
    else if(binaryArray[index] === 0)
    {
        if(consecutiveOnes >= tempConsecutiveOnes)
        {            
            tempConsecutiveOnes = consecutiveOnes;
        }
        consecutiveOnes = 0;
    }    
}

if(consecutiveOnes >= tempConsecutiveOnes)
{    
    tempConsecutiveOnes = consecutiveOnes;
}
console.log(tempConsecutiveOnes);

