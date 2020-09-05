function selectForm(lowerValue, upperValue) {
    var choices = upperValue - lowerValue + 1;
    return Math.floor(Math.random() * choices + lowerValue);
}

var num = selectForm(2, 10);
console.log(num);   //  介于2和10之间(包括2和10)的一个数值

var colors = ["red", "green", "blue", "yellow", "black", "puple", "brown"];
var color = colors[selectForm(0, colors.length - 1)];
console.log(color);