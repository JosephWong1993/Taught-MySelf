async function getComponent() {
    var elememnt = document.createElement("div");
    const _ = await import(/* webpackChunkName:"lodash" */ "lodash");

    elememnt.innerHTML = _.join(["Hello", "webpack"], " ");

    return elememnt;
}

getComponent().then(component => {
    document.body.appendChild(component);
})