var o = {
    toString: function () {
        return "MyObject";
    }
};

for (const prop in o) {
    if (prop == "toString") {
        console.log("Found toString");  //在IE中不会显示
    }
}