function Person(name, age, job) {
    this.name = name;
    this.age = age;
    this.job = jobl
    this.sayName = function () {
        console.log(this.name);
    };
}

var person1 = new Person("Nicholas", 29, "Software Engineer");
var person1 = new Person("Gerg", 27, "Doctor");

console.log(person1.constructor == Person); //true
console.log(person2.constructor == Person); //true
console.log(person1 instanceof Object);     //true
console.log(person1 instanceof Person);     //true
console.log(person2 instanceof Object);     //true
console.log(person2 instanceof Person);     //true