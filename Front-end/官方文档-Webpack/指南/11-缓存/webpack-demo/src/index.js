import _ from "lodash";
// import Print from "./print";

function component() {
    var elememnt = document.createElement("div");

    elememnt.innerHTML = _.join(["Hello", "webpack"], " ");
    // elememnt.onclick = Print.bind(null, "Hello webpack!");

    return elememnt;
}

document.body.appendChild(component());