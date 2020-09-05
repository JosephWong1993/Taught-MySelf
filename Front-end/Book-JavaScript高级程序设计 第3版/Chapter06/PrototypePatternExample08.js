function Person() {

}

//  对象字面量
Person.prototype = {
    // constructor: Person,    //导致constructor的[[Enumerable]]特性被设置为true
    name: "Nicholas",
    age: 29,
    job: "Software Engineer",
    sayname: function () {
        console.log(this.name);
    }
};

//重设构造函数,只适用于ECMAScript5兼容的浏览器
Object.defineProperty(Person.prototype, "constructor", {
    enumerable: false,
    value: Person
});

for (const key in Person.prototype) {
    const element = Person.prototype[key];
    console.log(element.toString());
}