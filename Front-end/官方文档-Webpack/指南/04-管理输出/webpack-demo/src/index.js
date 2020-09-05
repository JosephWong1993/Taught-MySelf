import _ from "lodash";
import printMe from "./print";

function component() {
    var elememnt = document.createElement("div");
    var btn = document.createElement("button");

    elememnt.innerHTML = _.join(["Hello", "webpack"], " ");
    btn.innerHTML = "CLick me and check the console!";
    btn.onclick = printMe;

    elememnt.appendChild(btn);

    return elememnt;
}

document.body.appendChild(component());