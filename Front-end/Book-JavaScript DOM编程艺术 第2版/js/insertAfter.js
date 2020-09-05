function insertAfter(newElement, targetElement) {
	var parent = targetElement.parentNode;
	if(targetElement == parent.lastChild) {
		parent.appendChild(newElement);
	} else {
		parent.insertBefore(newElement, targetElement.nextSibling);
	}
}