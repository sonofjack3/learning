/* JSON is a format for storing and transporting data */

/* Example: this is a JSON array (employees) with three JSON objects */
{
	"employees":[
		{"firstName":"John", "lastName":"Doe"},
		{"firstName":"Anna", "lastName":"Smith"},
		{"firstName":"Peter", "lastName":"Jones"}
	]
}

/* Converting JSON Text to a JavaScript object */
var text = '{ "employees":[' +
'{"firstName":"John", "lastName":"Doe"}, ' +
'{"firstName":"Anna", "lastName":"Smith"}, ' +
'{"firstName":"Peter", "lastName":"Jones"} ]}';
var obj = JSON.parse(text);
/* The variable obj has a single JavaScript array called employees */