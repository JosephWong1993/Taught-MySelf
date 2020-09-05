var text = "this has been a short summer";
var pattern = /(.)hort/g;

/**
 * 注意:Opera不支持input,lastMatch,lastParen和multiline属性
 * Internet Explorer不支持multiline属性
 */
if (pattern.test(text)) {
    console.log(RegExp.$_);     //  最近一次要匹配的字符串
    console.log(RegExp["$`"]);  //  input字符串中lastMatch之前的文本
    console.log(RegExp["$'"]);  //  Input字符串中lastMatch之后的文本
    console.log(RegExp["$&"]);  //  最后一次的匹配项
    console.log(RegExp["$+"]);  //  最近一次匹配的捕获组
    console.log(RegExp["$*"]);  //  布尔值,表示是否所有表达式都使用多行模式
}