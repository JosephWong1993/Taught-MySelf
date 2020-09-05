// import "babel-polyfill";

function component() {
    var element = document.crseateElement('div');

    element.innerHTML = join(['Hello', 'webpack'], ' ');

    //  Assume we are in the context of "window"
    this.alert("Hmmm, tthis probaly isn\'t a great iead...");

    return element;
}

document.body.appendChild(component());

fetch('http://jsonplaceholder.typicode.com/users')
    .then(response => response.json())
    .then(json => {
        console.log('We retrieved some data! AND we\'re confident it will work on a variety of browser distributions.');
        console.log(json);
    })
    .catch(error => console.error('Something went wrong when fetching this data:', error));