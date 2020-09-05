var text = "cat,bat,sat,fat";
var pattern = /.at/;

//  与pattern.exec(text)相同
var matches = text.match(pattern);
console.log(matches.index);     //  0
console.log(matches[0]);        //  "cat"
console.log(pattern.lastIndex); //  0

var pos = text.search(/at/);
console.log(pos);   //  1

var result = text.replace("at", "ond");
console.log(result);    //"cond,bat,sat,fat"

result = text.replace(/at/g, "ond");
console.log(result);    //"cond,bond,sond,fond"

result = text.replace(/(.at)/g, "word($1)");
console.log(result);    //"word(cat),word(bat),word(sat),word(fat)"

function htmlEscape(text) {
    return text.replace(/[<>"&]/g, function (match, pos, originalText) {
        switch (match) {
            case "<":
                return "&lt;";
            case ">":
                return "&gt;";
            case "&":
                return "&amp";
            case "\"":
                return "&quot;";
        }
    });
}
console.log(htmlEscape("<p class=\"greeting\">Hello world!</p>"));

var colorText = "red,blue,green,yellow";
var colors1 = colorText.split(",");
var colors2 = colorText.split(",", 2);
var colors3 = colorText.split(/[^\,]+/);
console.log(colors1);
console.log(colors2);
console.log(colors3);