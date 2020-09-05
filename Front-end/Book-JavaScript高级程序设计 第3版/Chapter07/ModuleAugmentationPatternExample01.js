function BaseComponent() {

}

var application = function () {
    //  私有变量和函数
    var components = new Array;

    //  初始化
    components.push(new BaseComponent());

    //  创建application的一个局部副本
    var app = new BaseComponent();

    app.getComponentCount = function () {
        return components.length;
    };
    app.registerComponent = function (component) {
        if (typeof component == "object") {
            components.push(component);
        }
    };

    //  返回这个副本
    return app;
}();