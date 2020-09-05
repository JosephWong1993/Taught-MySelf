function insertParagrph(text) {
	var str = '<p>';
	str += text;
	str += '</p>';
	document.write(str);
}

window.onload = function() {
	//	var testdiv = document.getElementById('testdiv');
	//	console.log(testdiv.innerHTML);
	//	testdiv.innerHTML = '<p>I inserted <em>this</em> content.</p>';

	var para = document.createElement('p');
	var txt1 = document.createTextNode('This is ');
	var emphasis = document.createElement('em');
	var txt2 = document.createTextNode('my');
	var txt3 = document.createTextNode(' content.')
	para.appendChild(txt1);
	emphasis.appendChild(txt2);
	para.appendChild(emphasis);
	para.appendChild(txt3);
	var testdiv = document.getElementById('testdiv');
	testdiv.appendChild(para);

	
}