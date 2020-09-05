var numberObject = new Number(10);

var num = 10;
console.log(num.toString());    //"10"
console.log(num.toString(2));   //"1010"
console.log(num.toString(8));   //"12"
console.log(num.toString(10));  //"10"
console.log(num.toString(16));  //"a"

console.log(num.toFixed(2));        //"10.00"

num = 10.005;
console.log(num.toFixed(2));        //"10.01"

num = 10;
console.log(num.toExponential(1));  //"1.0e+1"

num = 99;
console.log(num.toPrecision(1));    //"1e+2"
console.log(num.toPrecision(2));    //"99"
console.log(num.toPrecision(3));    //"99.0"

var numberObject = new Number(10);
var numberValue = 10;
console.log(typeof numberObject);   //"object"
console.log(typeof numberValue);    //"number"
console.log(numberObject instanceof Number);    //"true"
console.log(numberValue instanceof Number);     //"false"
