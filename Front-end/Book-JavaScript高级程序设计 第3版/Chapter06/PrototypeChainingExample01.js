function SupperType() {
    this.property = true;
}
SupperType.prototype.getSupperValue = function () {
    return this.property;
};

function SubType() {
    this.subproperty = false;
};

//  继承了SupperType
SubType.prototype = new SupperType();
SubType.prototype.getSubValue = function () {
    return this.subproperty;
};

var instance = new SubType();
console.log(instance.getSupperValue()); //true

console.log(instance instanceof Object);        //true
console.log(instance instanceof SupperType);    //true
console.log(instance instanceof SubType);       //true

console.log(Object.prototype.isPrototypeOf(instance));      //true
console.log(SupperType.prototype.isPrototypeOf(instance));  //true
console.log(SubType.prototype.isPrototypeOf(instance));     //true