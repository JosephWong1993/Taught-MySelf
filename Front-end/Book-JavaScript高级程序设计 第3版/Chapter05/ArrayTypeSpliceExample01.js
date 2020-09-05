var colors = ["red", "green", "blue"];
var removed = colors.splice(0, 1);  //  删除第一项
console.log(colors);    //  green,blue
console.log(removed);   //  red,返回的数组中只包含一项

removed = colors.splice(1, 0, "yellow", "orange");   //  从位置1开始插入两项
console.log(colors);    //  green,yellow,orange,blue
console.log(removed);   //  返回的是一个空数组

removed=colors.splice(1,1,"red","purple");  //  插入两项,删除一项
console.log(colors);    //  green,red,purple,orange,blue
console.log(removed);   //  yellow,返回的数组只包含一项