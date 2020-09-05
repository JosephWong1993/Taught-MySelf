console.log(isNaN(NaN));    //true
console.log(isNaN(10));     //false(10是一个数值)
console.log(isNaN("10"));   //false(可以被转换成数值10)
console.log(isNaN("blue")); //true(不能转换成数值)
console.log(isNaN(true));   //false(可以被转换成数值1)