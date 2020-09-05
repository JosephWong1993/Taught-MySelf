function Person() { }
Person.prototype.name = "Nicholas";
Person.prototype.age = 29;
Person.prototype.job = "Software Engineer";
Person.prototype.sayname = function () {
    console.log(this.name);
};
var person1 = new Person();
var person2 = new Person();

console.log(person1.hasOwnProperty("name"));    //false

person1.name = "Greg";
console.log(person1.name);  //"Greg"--来自实例
console.log(person1.hasOwnProperty("name"));    //true

console.log(person2.name);  //"Nicholas"--来自原型
console.log(person1.hasOwnProperty("name"));    //false

delete person1.name;
console.log(person1.name);  //"Nicholas"--来自原型
console.log(person1.hasOwnProperty("name"));    //false