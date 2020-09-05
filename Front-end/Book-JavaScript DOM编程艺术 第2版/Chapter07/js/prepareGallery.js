function addLoadEvent(func) {
	var oldonload = window.onload;
	if(typeof window.onload != 'function') {
		window.onload = func;
	} else {
		window.onload = function() {
			oldonload();
			func();
		}
	}
}

function insetAfter(newElement, targetElement) {
	var parent = targetElement.parentNode;
	if(targetElement == parent.lastChild) {
		parent.appendChild(newElement);
	} else {
		parent.insertBefore(newElement, targetElement.nextSibling);
	}
}

function preparePlaceholder() {
	if(!document.createElement) return false;
	if(!document.createTextNode) return false;
	if(!document.getElementById) return false;
	if(!document.getElementById('imagegallery')) return false;

	var placeholder = document.createElement('img');
	placeholder.setAttribute('id', 'placeholder');
	placeholder.setAttribute('src', '../img/placeholder.gif');
	placeholder.setAttribute('alt', 'my image gallery');
	var description = document.createElement('p');
	description.setAttribute('id', 'description');
	var destext = document.createTextNode('Choose an image');
	description.appendChild(destext);

	//	var body = document.getElementsByTagName('body')[0];
	//	body.appendChild(placeholder);
	//	body.appendChild(description);

	var gallery = document.getElementById('imagegallery');
	insetAfter(placeholder, gallery);
	insetAfter(description, placeholder);
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

addLoadEvent(                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         );
addLoadEvent(prepareGallery);