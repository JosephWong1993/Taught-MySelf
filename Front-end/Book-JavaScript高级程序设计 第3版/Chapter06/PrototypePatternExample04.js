function Person() {
    sayName = function () {
        console.log(this.name);
    };
}
Person.prototype.name = "Nicholas";
Person.prototype.age = 29;
Person.prototype.job = "Software Engineer";
Person.prototype.sayName = function () {
    console.log(this.name);
};
var o;
Person.apply(o)
var person1 = new Person();
var person2 = new Person();

console.log(person1.hasOwnProperty("name"));    //false
console.log("name" in person1);                 //true

person1.name = "Greg";
console.log(person1.name);                      //"Greg"--来自实例
console.log(person1.hasOwnProperty("name"));    //true
console.log("name" in person1);                 //true

console.log(person2.name);                      //"Nicholas"--来自原型
console.log(person2.hasOwnProperty("name"));    //false
console.log("name" in person2);                 //true

delete person1.name;
console.log(person1.name);                      //"Nicholas"--来自原型
console.log(person1.hasOwnProperty("name"));    //false
console.log("name" in person1);                 //true