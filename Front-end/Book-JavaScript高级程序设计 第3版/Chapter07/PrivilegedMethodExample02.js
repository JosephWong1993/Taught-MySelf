var Person;

(function () {
    var name = "";

    Person = function (value) {
        name = value;
    };
    Person.prototype.getName = function () {
        return name;
    };
    Person.prototype.setName = function (value) {
        name = value;
    };
})();

var person1 = new Person("Nicholas");
console.log(person1.getName()); //"Nicholas"
person1.setName("Greg");
console.log(person1.getName()); //"Greg"

var person2 = new Person("Michael");
console.log(person1.getName()); //"Michael"
console.log(person2.getName()); //"Michael"