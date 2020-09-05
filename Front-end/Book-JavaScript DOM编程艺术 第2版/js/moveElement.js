function moveElement(elementId, final_x, final_y, interval) {
	if(!document.getElementById) return false;
	var elem = document.getElementById(elementId);
	if(!elem) return false;
	if(elem.movement) {
		clearTimeout(elem.movement);
	}
	if(!elem.style.left) {
		elem.style.left = '0px';
	}
	if(!elem.style.top) {
		elem.style.top = '0px';
	}
	var xPos = parseInt(elem.style.left);
	var yPos = parseInt(elem.style.top);
	if(xPos == final_x && yPos == final_y) {
		return true;
	}
	var dist = 0;
	if(xPos < final_x) {
		dist = Math.ceil((final_x - xPos) / 10);
		xPos = xPos + dist;
	} else if(xPos > final_x) {
		dist = Math.ceil((xPos - final_x) / 10);
		xPos = xPos - dist;
	}
	if(yPos < final_y) {
		dist = Math.ceil((final_y - yPos) / 10);
		yPos = yPos + dist;
	} else if(yPos > final_y) {
		dist = Math.ceil((yPos - final_y) / 10);
		yPos = yPos - dist;
	}

	elem.style.left = xPos + 'px';
	elem.style.top = yPos + 'px';

	var repart = 'moveElement(\'' + elementId + '\', ' + final_x + ',' + final_y + ',' + interval + ')';
	elem.movement = window.setTimeout(repart, interval);
}