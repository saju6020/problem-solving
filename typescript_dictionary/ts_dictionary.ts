'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');
let inputString: string = '';
let inputLines: string[] = [];
let currentLine: number = 0;
process.stdin.on('data', function(inputStdin: string): void {
    inputString += inputStdin;
});

process.stdin.on('end', function(): void {
    inputLines = inputString.split('\n');
    inputString = '';
    main();
});

function readLine(): string {
    return inputLines[currentLine++];
}

function main() {
    // Enter your code here
    const ts_dictionary = new Map<string, string>();
    
      let totalTestCases =  +readLine();       
      let testCasesIndex:number =0;   
         
        while(testCasesIndex != totalTestCases)
        {                  
        // Enter your code here
            let inputString = readLine();
            let inputArray:string[] = inputString.split(" "); 
           // console.log(`${inputArray[0]} ${inputArray[1]}`);                
            ts_dictionary.set(inputArray[0], inputArray[1]);
            testCasesIndex++;                    
        }
        
        testCasesIndex = 0;
        let inputString = readLine();
        
         while(inputString != undefined)
        {                  
        // Enter your code here                                               
            let strvalue = ts_dictionary.get(inputString);
            testCasesIndex++;   
            if(strvalue != undefined)
            {
                console.log(`${inputString}=${strvalue}`);   
            }
            else
            {
                console.log("Not found")
            }   
            
            inputString = readLine();
        }
        
}