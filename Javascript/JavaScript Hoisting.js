/* A JavaScript variable can be used before it has been declared (declarations are "hoisted") */
x = 5;
elem = document.getElementById("demo");
elem.innerHTML = x;
var x;

/* JavaScript does not hoist initializations (must come before the variable is used for the expected value to be set) */
var x; //x is unitialized and is therefore undefined
document.getElementById("demo").innerHTML = x; //undefined
x = 7; //only now x is set to 7