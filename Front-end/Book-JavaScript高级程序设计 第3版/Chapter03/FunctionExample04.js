function sayHi(name, message) {
    return;
    console.log("Hello " + name + "," + message);   //  永远不会调用
}

sayHi("Nicholas", "how are you today?");