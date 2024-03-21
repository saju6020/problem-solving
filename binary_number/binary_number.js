function getBinaryNumber(num) {
    var output = [];
    while (num >= 1) {
        var binary_bit = num % 2;
        output.push(binary_bit);
        num = Math.floor(num / 2);
    }
    return output;
}
var binaryArray = getBinaryNumber(439);
var tempConsecutiveOnes = 0;
var consecutiveOnes = 0;
var strOutput = '';
for (var index = binaryArray.length - 1; index >= 0; index--) {
    // console.log(binaryArray[index]);
    if (binaryArray[index] === 1) {
        consecutiveOnes++;
    }
    else if (binaryArray[index] === 0) {
        if (consecutiveOnes >= tempConsecutiveOnes) {
            tempConsecutiveOnes = consecutiveOnes;
        }
        consecutiveOnes = 0;
    }
}
if (consecutiveOnes >= tempConsecutiveOnes) {
    tempConsecutiveOnes = consecutiveOnes;
}
console.log(tempConsecutiveOnes);
