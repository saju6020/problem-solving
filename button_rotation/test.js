function reductionCost(num) {
    let totalCost = 0;
    num.sort(function(a, b){return a - b});

    while(num.length > 1)
    {
    // Write your code here
        let firstNum = num.shift();
        let secondNum = num.shift();
        let cost = firstNum + secondNum;
        totalCost = totalCost + cost;
        num.push(cost)
        num.sort(function(a, b){return a - b});
    }
    return totalCost;
}

let num =[1,2,3,4]
let outPut = reductionCost(num);
console.log(outPut);
