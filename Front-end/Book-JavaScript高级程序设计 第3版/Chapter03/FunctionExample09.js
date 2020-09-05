function doAdd(num1, num2) {
    arguments[1] = 10;
    console.log(arguments[0] + num2);
}

doAdd(10, 20);  //  20
doAdd(30, 20);  //  50