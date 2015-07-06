/* Methods for speeding up JavaScript code */

/* Reduce activity in loops */
/* For example, use: */
var l = arr.length;
for (i = 0; i < l; i++) {}
/* Instead of: */
for (i = 0; i < arr.length; i++) {}

/* Reduce DOM access when an element is going to be used more than once */
/* For example, use: */
var obj = document.getElementById("demo");
obj.innerHTML = "Hello";
/* Instead of: */
document.innerHTML.getElementById("demo").innerHTML = "Hello";
/* Conversely, don't create new variables if they aren't going to be used multiple times */

/* Scripts should be loaded after the page has loaded */
/* One way to do this is to put the following block in the HTML */
<script>
window.onload = downScripts;

function downScripts() {
	var element = document.createElement("script");
	element.src = "myScript.js";
	document.body.appendChild(element);
}
</script>