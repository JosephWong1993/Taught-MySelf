var text = "this has been a short summer";
var pattern = /(..)or(.)/g;

if (pattern.test(text)) {
    console.log(RegExp.$1); //  sh
    console.log(RegExp.$2); //  t
}