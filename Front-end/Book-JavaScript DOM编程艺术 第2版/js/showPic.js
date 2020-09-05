function showPic(whichPic) {
	if(!document.getElementById('placeholder')) return false;
	var placeholder = document.getElementById('placeholder');
	if(placeholder.nodeName != 'IMG') return false;

	var source = whichPic.getAttribute('href');
	placeholder.setAttribute('src', source);

	if(document.getElementById('description')) {
		var text = whichPic.getAttribute('title') ? whichPic.getAttribute('title') : '';
		var description = document.getElementById('description');
		if(description.firstChild.nodeType == 3) {
			description.firstChild.nodeValue = text;
		}
	}
	return true;
}

function countBodyChildren() {
	var body_element = document.getElementsByTagName('body')[0];
	//	console.log(body_element.childNodes.length);
	console.log(body_element.nodeType);
}