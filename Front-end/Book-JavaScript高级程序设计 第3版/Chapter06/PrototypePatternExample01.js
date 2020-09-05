function Person() { };

Person.prototype.name = "Nicholas";
Person.prototype.age = 29;
Person.prototype.job = "Software Engineer";
Person.prototype.sayName = function () {
    console.log(this.name);
};

var person1 = new Person();
person1.sayName();  //"Nicholas"

var person2 = new Person();
person2.sayName();  //"Nocholas"

console.log(Person.prototype.isPrototypeOf(person1));   //true
console.log(Person.prototype.isPrototypeOf(person2));   //true'

console.log(Object.getPrototypeOf(person1) == Person.prototype);    //true
console.log(Object.getPrototypeOf(person1).name);   //"Nicholas"