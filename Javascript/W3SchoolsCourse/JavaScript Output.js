/* JavaScript can display data in different ways:
	-window.alert() - writes to an alert box
	-document.write() - writes to HTML output
	-innerHTML - writes into an HTML element
	-console.log() - writing into the browser console
*/

function alertMethod () {
	window.alert("Alert!");
}

/* NOTE: this should be used only for testing purposes */
/* NOTE: if document.write() is used after a document is loaded, it will erase all HTML on the page */
function documentWriteMethod() {
	document.write("Document.write");
}

function innerHTMLMethod() {
	document.getElementById("text1").innerHTML = 5 + 5;
}

function consoleLogMethod() {
	console.log('More like blog amirite');
}