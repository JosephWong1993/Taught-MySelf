var s1 = "01";
var s2 = "1.1";
var s3 = "z";
var b = false;
var f = 1.1;
var o = {
    valueOf: function () {
        return -1;
    }
}

s1 = -s1;   //  值变成数值-1
s2 = -s2;   //  值变成数值-1.1
s3 = -s3;   //  值变成NaN
b = -b;     //  值变成数值0(-0)
f = -f;     //  值未变,仍然时-1.1
o = -o;     //  值变成数值1

console.log(s1);
console.log(s2);
console.log(s3);
console.log(b);
console.log(f);
console.log(o);