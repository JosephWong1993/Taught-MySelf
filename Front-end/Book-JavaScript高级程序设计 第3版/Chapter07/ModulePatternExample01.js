function BaseComponent(){
    
}

var application = function () {
    //  私有变量和函数
    var components = new Array();

    //  初始化
    components.push(new BaseComponent());

    //  公共
    return {
        getComponentCount: function () {
            return components.length;
        },
        registerComponent: function (component) {
            if (typeof component == "object") {
                components.push(component);
            }
        }
    }
}();