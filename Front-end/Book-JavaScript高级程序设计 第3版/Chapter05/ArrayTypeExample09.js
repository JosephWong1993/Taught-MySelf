var colors = new Array();   //  创建一个数组
var count = colors.push("red", "green");    //  推入两项
console.log(count); //  2

count = colors.push("black");   //  推入另一项
console.log(count); //  3

var item = colors.pop();    //  取得最后一项
console.log(item);  //  "black"
console.log(colors.length); //  2