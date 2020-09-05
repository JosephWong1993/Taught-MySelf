function SpecialArray() {
    //  创建数组
    var values = new Array();

    //  添加值
    values.push.apply(values, arguments);

    //  添加方法
    values.toPipedString = function () {
        return this.join("|");
    };

    //  返回数组
    return values;
}

var colors = new SpecialArray("red", "blue", "green");
console.log(colors.toPipedString());    //"red|blue|green"

function Person(name, age, job) {
    //  创建要返回的对象
    var o = new Object();

    //  可以在这里定义私有变量和函数

    //  添加方法
    o.sayName = function () {
        console.log(name);
    }

    //  返回对象
    return o;
}
var friend = Person("Nicholas", 29, "Software Engineer");
friend.sayName();