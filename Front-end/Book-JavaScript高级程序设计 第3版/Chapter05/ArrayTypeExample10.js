var colors = ["red", "blue"];
colors.push("brown");   //  添加另一项
colors[3] = "black";    //  添加一项
console.log(colors.length); //  4

var item=colors.pop();  //  取得最后一项
console.log(item);      //  "black"