function getNewContect() {
	var request = getHTTPObject();
	if(request) {
		request.open('GET', 'example.txt', true);
		request.onreadystatechange = function() {
			//	处理响应
			if(request.readyState == 4) {
				alert('Response Received');
				var para = document.createElement('p');
				var txt = document.createTextNode(request.responseText);
				para.appendChild(txt);
				document.getElementById('new').appendChild(para);
			}
		};
		request.send(null);
	} else {
		alert('Sorry, your browser doesn\'t support XMLHttpRequest');
	}
	alert('Function Done');
}

addLoadEvent(getNewContect);