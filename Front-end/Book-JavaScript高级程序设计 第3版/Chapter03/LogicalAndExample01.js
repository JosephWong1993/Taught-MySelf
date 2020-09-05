var found = true;
var result = (found && someUndefinedVariable);  //  这里会发生错误
console.log(result);    //  这一行不会执行