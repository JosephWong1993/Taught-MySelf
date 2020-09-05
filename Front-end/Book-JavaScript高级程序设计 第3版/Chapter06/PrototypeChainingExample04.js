function SuperType() {
    this.colors = ["red", "blue", "green"];
}

function SubType() {

}

//  继承了SupperType
SubType.prototype = new SuperType();

var instance1 = new SubType();
instance1.colors.push("black");
console.log(instance1.colors.toString());   //red,blue,green,black

var instance2 = new SubType();
instance2 = new SubType();
console.log(instance2.colors.toString());   //red,blue,green,black