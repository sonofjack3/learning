/* JavaScript can change HTML content */
/* Changes text of element with id "demo" */
function changeText() {
		document.getElementById('demo').innerHTML = 'How dare you';
}

/* JavaScript can change HTML attributes */
/* Changes image with id "bulb" */
function changeLight () {
	var image = document.getElementById('bulb');
	if (image.src.match("bulbon")) {
		image.src = "images/pic_bulboff.gif";
	}
	else {
		image.src = "images/pic_bulbon.gif";
	}
}

/* JavaScript can change HTML Styles (CSS) */
/* Changes font size of element with id "demo" */
function changeFontSize () {
	document.getElementById("demo").style.fontSize = "25px";
}

/* JavaScript can validate data */
/* Sets text of element with id validateText based on value in text box */
function between1and10 () {
	var x, text;
	x = document.getElementById("numb").value;
	if (isNaN(x) || x < 1 || x > 10) {
		text = "Nononononononononononono";
	}
	else {
		text = "Oooh ur luky";
	}
	document.getElementById("validateText").innerHTML = text;
}