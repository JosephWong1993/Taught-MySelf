import _ from "lodash";
import "./style.css";
import Icon from "./icon.jpg";
import Data from "./data.xml";

function component() {
    var elememnt = document.createElement("div");

    //  Lodash, 现在由此脚本导入
    elememnt.innerHTML = _.join(["Hello", "webpack"], " ");
    elememnt.classList.add("hello");

    //  将此图像添加到我们现有的div
    var myIcon = new Image();
    myIcon.src = Icon;

    elememnt.appendChild(myIcon);

    console.log(Data);

    return elememnt;
}

document.body.appendChild(component());