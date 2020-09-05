// var person = new Object();
// person.name = "Nicholas";
// person.age = 29;
// person.job = "Software Engineer";
// person.sayName = function () {
//     console.log(this.name);
// };

//  对象字面量
var person = {
    name: "Nicholas",
    age: 29,
    job: "Software Engineer",

    sayName: function () {
        console.log(this.name);
    }
}

console.log(person);