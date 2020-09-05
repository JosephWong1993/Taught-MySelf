function addClass(element, value) {
	if(element.className) {
		element.className = element.className + ' ' + value;
	} else {
		element.className = value;
	}
}