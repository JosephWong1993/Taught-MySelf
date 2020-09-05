function callSomeFunction(someFuction, someArgument) {
    return someFuction(someArgument);
}

function add10(num) {
    return num + 10;
}

var result1 = callSomeFunction(add10, 10);
console.log(result1);

function getGreeting(name) {
    return "Hello, " + name;
}

var result2 = callSomeFunction(getGreeting, "Nicholas");
console.log(result2);