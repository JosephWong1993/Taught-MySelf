var person = {};
Object.defineProperty(person, "name", {
    configurable: false,
    value: "Nicholas"
});

console.log(person.name);

//  抛出错误
Object.defineProperty(person, "name", {
    configurable: true,
    value: "Nicholas"
});

console.log(person.name);