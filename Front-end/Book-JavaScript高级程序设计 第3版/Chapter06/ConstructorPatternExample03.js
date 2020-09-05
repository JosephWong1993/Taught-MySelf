function Person(name, age, job) {
    this.name = name;
    this.age = age;
    this.job = job;
    this.sayName = sayName;
}

function sayName() {
    console.log(this.name);
}

var person1 = new Person("Nocholas", 29, "Software Engineer");
var person2 = new Person("Greg", 27, "Doctor");