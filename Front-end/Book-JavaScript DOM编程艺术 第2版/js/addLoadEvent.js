function addLoadEvent(func) {
	var old_onload = window.onload;
	if(typeof old_onload == 'function') {
		window.onload = function() {
			old_onload();
			func();
		}
	} else {
		window.onload = func;
	}
}