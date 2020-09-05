var person = {
    name:" "
};
Object.defineProperty(person, "name", {
    configurable: false,
    writable: true,
    value: "Nicholas"
});

console.log(person.name);
delete person.name;
console.log(person.name);