import _ from "lodash";

function component() {
    var elememnt = document.createElement("div");

    var button = document.createElement("button");
    var br = document.createElement("br");

    button.innerHTML = "Click me and look at the console!";
    elememnt.innerHTML = _.join(["Hello", "webpack"], " ");
    elememnt.appendChild(br);
    elememnt.appendChild(button);

    button.onclick = e => import(/* webpackChunkName: "print" */ "./print").then(module => {
        var print = module.default;
        print();
    });

    return elememnt;
}

document.body.appendChild(component());