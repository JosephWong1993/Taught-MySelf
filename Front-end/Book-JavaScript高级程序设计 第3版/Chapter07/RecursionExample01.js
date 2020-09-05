//  Recursion   n.递推,递归,递归式

function factorial(num) {
    if (num <= 1) {
        return 1;
    } else {
        return num * factorial(num - 1);
    }
}

var anotherFactorial = factorial;
factorial = null;
console.log(anotherFactorial(4));   //出错!