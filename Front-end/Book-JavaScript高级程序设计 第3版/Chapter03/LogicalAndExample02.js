var found = false;
var result = (found && someUndefinedVariable);  //  不会发生错误
console.log(result);    //  会执行("false");