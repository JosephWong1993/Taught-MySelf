function Person() {

}

Person.prototype = {
    constructor: Person,
    name: "Nicholas",
    age: 29,
    job: "Software Engineer",
    frineds: ["Shellby", "Court"],
    sayName: function () {
        console.log(this.name);
    }
};

var person1 = new Person();
var person2 = new Person();
person1.frineds.push("Van");

console.log(person1.frineds.toString());        //Shellby,Court,Van
console.log(person2.frineds.toString());        //Shellby,Court,Van
console.log(person1.frineds===person2.frineds); //true