var text = "this has been a short summer";
var pattern = /(.)hort/g;

/**
 * 注意:Opera不支持input,lastMatch,lastParen和multiline属性
 * Internet Explorer不支持multiline属性
 */
if (pattern.test(text)) {
    console.log(RegExp.input);
    console.log(RegExp.leftContext);
    console.log(RegExp.rightContext);
    console.log(RegExp.lastMatch);
    console.log(RegExp.lastParen);
    console.log(RegExp.multiline);
}