function positionMessage() {
	if(!document.getElementById) return false;
	var elem = document.getElementById('message')
	if(!elem) return false;

	elem.style.position = 'absolute';
	elem.style.left = '50px';
	elem.style.top = '100px';
	//	movement = setTimeout('moveMessage()', 10);
	moveElement('message', 125, 25, 20);

	elem = document.getElementById('message2');0
	if(!elem) return false;
	elem.style.position = 'absolute';
	elem.style.left = '50px';
	elem.style.top = '50px';
	moveElement('message2', 125, 125, 20);
}

function moveMessage() {
	if(!document.getElementById) return false;
	var elem = document.getElementById('message');
	if(!elem) return false;
	//	elem.style.left = '200px';
	var xpos = parseInt(elem.style.left);
	var ypos = parseInt(elem.style.top);
	if(xpos == 200 && ypos == 100) {
		return true;
	}
	if(xpos < 200) {
		xpos++;
	} else if(xpos > 200) {
		xpos--
	}
	if(ypos < 100) {
		ypos++;
	} else if(ypos > 100) {
		ypos--;
	}
	elem.style.left = xpos + 'px';
	elem.style.top = ypos + 'px';
	movement = setTimeout('moveMessage()', 10);
}

addLoadEvent(positionMessage);