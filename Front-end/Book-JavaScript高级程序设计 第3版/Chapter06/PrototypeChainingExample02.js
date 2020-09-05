function SuperType() {
    this.property = true;
}

SuperType.prototype.getSuperValue = function () {
    return this.property;
};

function SubType() {
    this.subproperty = false;
}
//  继承了SuperType
SubType.prototype = new SuperType();

//  添加新方法
SubType.prototype.getSubValue = function () {
    return this.subproperty;
};

//  重写超类型中的方法
SubType.prototype.getSuperValue = function () {
    return false;
}

var instance = new SubType();
console.log(instance.getSuperValue());  //false