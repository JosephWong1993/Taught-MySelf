var stringValue = "Lorem ipsum dolor sit amet, consectetur adipisicing elit";
var positions = new Array();
var pos = stringValue.indexOf("e");

while (pos > -1) {
    positions.push(pos);
    pos = stringValue.indexOf("e", pos + 1);
}

console.log(positions.toString());  //"3,24,32,35,52"