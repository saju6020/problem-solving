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
       
      let totalTestCases =  +readLine();       
      let testCasesIndex:number =0;   
         
        while(testCasesIndex != totalTestCases)
        {                  
        // Enter your code here
            let person = new Person(+readLine());
            person.amIOld();
            person.yearPasses();
            person.yearPasses();
            person.yearPasses();
            person.amIOld();            
            testCasesIndex++; 
            console.log();            
        }
    
}

class Person{
    age:number = 0;
    constructor(initialAge:number)
    {
        if(initialAge < 0)
        {
            console.log("Age is not valid, setting age to 0.")
        }
        else
        {
            this.age = initialAge;
        }
    }
    
    public yearPasses()
    {
        this.age += 1;
    }
    
    public amIOld()
    {
        if(this.age < 13)
        {
            console.log("You are young.");
        }
        else if(this.age >= 13 && this.age < 18)
        {
            console.log("You are a teenager.");
        }
        else
        {
            console.log("You are old.");
        }
    }
}