function outer() {
    inner();
}

function inner() {
    console.log(arguments.callee.caller.toString());
}

outer();