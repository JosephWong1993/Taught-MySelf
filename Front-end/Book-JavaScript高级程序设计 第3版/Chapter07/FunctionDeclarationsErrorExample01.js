var condition = true;

//  不要这样做!
// if (condition) {
//     function sayHi() {
//         console.log("Hi!");
//     }
// } else {
//     function sayHi() {
//         console.log("Yo!");
//     }
// }

//  可以这样做!
var sayHi;
if (condition) {
    sayHi = function () {
        console.log("Hi!");
    }
} else {
    sayHi = function () {
        console.log("Yo!");
    }
}

sayHi();