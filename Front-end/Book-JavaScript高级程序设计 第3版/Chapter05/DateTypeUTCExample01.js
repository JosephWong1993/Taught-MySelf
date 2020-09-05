//  GMT时间2000年1月1日午夜零时
var y2k = new Date(Date.UTC(2000, 0));

//  GMT时间2005年5月5日下午5:55:55
var allFives = new Date(Date.UTC(2005, 4, 5, 17, 55, 55));

console.log(y2k);
console.log(allFives);