import _ from "lodash";
import printMe from "./print";

if ('serviceWorker' in navigator) {
    window.addEventListener('load', () => {
        navigator.serviceWorker.register('/sw.js')
            .then(registration => {
                console.log('SW registered: ', registration);
            })
            .catch(registrationError => {
                console.log('SW registration failed: ', registrationError);
            });
    })
}

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