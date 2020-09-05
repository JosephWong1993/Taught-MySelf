function Person() {

}
Person.prototype.name = "Nicholas";
Person.prototype.age = 29;
Person.prototype.job = "Software Engineer";
Person.prototype.sayName = function () {
    console.log(this.name);
};

var keys = Object.getOwnPropertyNames(Person.prototype);
console.log(keys);