function factorial(n) {
    // Write your code here
    if (n == 0) {
        return 1;
    }
    else {
        return n * factorial(n - 1);
    }
}
console.log(factorial(6));
