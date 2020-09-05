console.log(typeof Array.prototype.sort);       //"function"
console.log(typeof String.prototype.substring); //"function"

String.prototype.startsWith = function (text) {
    return this.indexOf(text) == 0;
};

var msg = "Hello world!";
console.log(msg.startsWith("Hello"));   //true