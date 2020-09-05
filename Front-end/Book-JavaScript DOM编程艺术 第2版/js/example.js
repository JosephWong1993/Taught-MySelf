//var height = "about 5'10\" tall";
//alert(height);

//var beats = Array(4);
//beats[0] = 'John';
//beats[1] = 'Paul';
//beats[2] = 'George';
//beats[3] = 'Ringo';+

//var beatles = Array('John', 'Paul', 'George', 'Ringo');
//var beatles = ['John', 'Paul', 'George', 'Ringo'];

function shout() {
	var beatles = Array('John', 'Paul', 'George', 'Ringo');
	for(var count = 0; count < beatles.length; count++) {
		alert(beatles[count]);
	}
}

function multiply(num1, num2) {
	var total = num1 * num2;
	return total;
}

function convertToCelsius(temp) {
	var result = temp - 32;
	result = result / 1.98;
	return result;
}

function getElementsByClassName(node, classname) {
	if(node.getElementsByClassName) {
		//	使用现有方法
		return node.getElementsByClassName(classname);
	} else {
		var results = new Array();
		var elems = node.getElementsByTagName('*');
		for(var i = 0; i < elems.length; i++) {
			if(elems[i].className.indexOf(classname) != -1) {
				results[results.length] = elems[i];
			}
		}
	}
}