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

function prepareGallery(whichPic) {
	if(!document.getElementsByTagName) {
		return false;
	}
	if(!document.getElementById) {
		return false;
	}
	if(!document.getElementById('imagegallery')) {
		return false;
	}
	var gallery = document.getElementById('imagegallery');
	var links = gallery.getElementsByTagName('a');
	for(var i = 0; i < links.length; i++) {
		links[i].onclick = function() {
			return showPic(this) ? false : true;
		};
		//		links[i].onkeypress = links[i].onClick();
	}
}

function addLoadEvent(func) {
	var oladonload = window.onload;
	if(typeof window.onload != 'function') {
		window.onload = func;
	} else {
		window.onload = function() {
			oladonload();
			func();
		}
	}
}

addLoadEvent(prepareGallery);