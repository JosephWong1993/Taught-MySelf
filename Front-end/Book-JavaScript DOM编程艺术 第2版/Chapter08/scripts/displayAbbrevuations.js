function displayAbbreviations() {
	if(!document.getElementsByTagName) return false;
	if(!document.createElement) return false;
	if(!document.createTextNode) return false;

	//	取得所有缩略词
	var abbreviations = document.getElementsByTagName('abbr');
	if(abbreviations.length < 1) return false;
	var defs = new Array();
	//	遍历这些缩略词
	for(var i = 0; i < abbreviations.length; i++) {
		var current_abbr = abbreviations[i];
		if(current_abbr.childNodes.length < 1) continue;
		var definition = current_abbr.getAttribute('title');
		var key = current_abbr.lastChild.nodeValue;
		defs[key] = definition;
	}

	//	创建定义列表
	var dlist = document.createElement('dl')
	//	便利定义
	for(key in defs) {
		var definition = defs[key];
		//	创建定义标题
		var dtitle = document.createElement('dt');
		var dtitle_text = document.createTextNode(key);
		dtitle.appendChild(dtitle_text);
		//	创建定义描述
		var ddesc = document.createElement('dd');
		var ddesc_text = document.createTextNode(definition);
		ddesc.appendChild(ddesc_text);
		//	把他们添加到定义列表
		dlist.appendChild(dtitle);
		dlist.appendChild(ddesc);
	}
	if(dlist.childNodes.length < 1) return false;

	//	创建标题
	var header = document.createElement('h2');
	var header_text = document.createTextNode('Abbreviations');
	header.appendChild(header_text);

	//	把标题添加到页面主体
	document.body.appendChild(header);
	document.body.appendChild(dlist);
}

addLoadEvent(displayAbbreviations);