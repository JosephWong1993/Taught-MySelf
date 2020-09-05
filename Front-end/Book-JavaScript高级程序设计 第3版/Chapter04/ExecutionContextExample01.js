var color = "blue";

function changeColor() {
    if (color === "blue") {
        color = "red";
    } else {
        color = "blue";
    }
}

changeColor();

console.log("Color is now " + color);