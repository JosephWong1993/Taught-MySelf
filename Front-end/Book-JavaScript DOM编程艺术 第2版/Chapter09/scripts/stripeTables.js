function stripeTables() {
	if(!document.getElementsByTagName) return false;
	var tables = document.getElementsByTagName('table');
	var rows, odd;
	for(var i = 0; i < tables.length; i++) {
		odd = false;
		rows = tables[i].getElementsByTagName('tr');
		for(var j = 0; j < rows.length; j++) {
			if(odd == true) {
				//				rows[j].style.backgroundColor = '#ffc';
				addClass(this, 'odd');
				odd = false;
			} else {

				odd = true;
			}
		}
	}
}

addLoadEvent(stripeTables);