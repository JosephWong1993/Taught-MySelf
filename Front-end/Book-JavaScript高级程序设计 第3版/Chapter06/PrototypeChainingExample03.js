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

//  使用字面量添加新方法,会导致上一行代码无效
SubType.prototype = {
    getSubValue: function () {
        return this.subproperty;
    },
    someOtherMethod: function () {
        return false;
    }
}


var instance = new SubType();
console.log(instance.getSuperValue());  //error