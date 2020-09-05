var now = new Date();
// var someDate = new Date(Date.parse("May 25,2004"));
var someDate = new Date("May 25,2004"); //  会在后台调用Date.parse()

console.log(now);
console.log(someDate);
console.log();