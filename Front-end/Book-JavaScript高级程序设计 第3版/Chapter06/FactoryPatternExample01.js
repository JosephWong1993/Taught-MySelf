function createPerson(name, age, job) {
    var o = new Object();
    o.name = name;
    o.age = age;
    o.job = job;
    o.sayName = function () {
        console.log(this.name);
    };
    return o;
}

var person1 = createPerson("Nocholas", 29, "Software Engineer");
var person2 = createPerson("Greg", 27, "Doctor");