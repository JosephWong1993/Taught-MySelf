import _ from "lodash";
import printMe from "./print";
import "./styles.css"

function component() {
    var elememnt = document.createElement("div");
    var btn = document.createElement("button");

    elememnt.innerHTML = _.join(["Hello", "webpack"], " ");
    btn.innerHTML = "CLick me and check the console!";
    btn.onclick = printMe;

    elememnt.appendChild(btn);

    return elememnt;
}

let elememnt = component();   //  当print.js改变导致页面重新渲染时,重新获取渲染的元素
document.body.appendChild(elememnt);

if (module.hot) {
    module.hot.accept("./print.js", function () {
        console.log("Accepting the updated printMe module!");

        document.body.removeChild(elememnt);
        elememnt = component();   //  重新渲染页面后,component更新click事件处理
        document.body.appendChild(elememnt);
    });
}