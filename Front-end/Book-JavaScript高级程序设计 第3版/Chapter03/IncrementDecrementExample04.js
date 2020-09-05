var s1 = "2";
var s2 = "z";
var b = false;
var f = 1.1;
var o = {
    valueof: function () {
        return -1;
    }
};

s1++;   //  值变成数值3
s2++;   //  值变成NaN
b++;    //  值变成数值1
f--;    //  值变成数值0.10000000000000009(由于浮点舍入错误所致)
o--;    //  值变成数值-2

console.log(s1);
console.log(s2);
console.log(b);
console.log(f);
console.log(o);