var color = "blue";

function changeColor() {
    var antherColor = "red";

    function swapColors() {
        var tempColor = antherColor;
        antherColor = color;
        color = tempColor;

        //  这里可以访问color,anotherColor和tempColor
    }

    //  这里可以访问color和anotherColor,但不能访问tempColor
    swapColors();
}

//  这里只能访问color
changeColor();

console.log(color);