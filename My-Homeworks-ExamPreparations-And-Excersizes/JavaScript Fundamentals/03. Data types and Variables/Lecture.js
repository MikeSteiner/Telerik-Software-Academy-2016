/* globals console, parseint, parseFloat */
"use strict"

var number = 10;
var isZero = !!number;

console.log(number);

//------------------

var firstName = "John";
var lastName = "Doe";
var fullname = firstName + " " + lastName;

var said = "\"Hello\"";

var multiLineText = `This is 
a 
multiline 
text`;

var multiLineText = "This is " +
					"a " +
					"multiline " +
					"text.";
					
					
//------------------

var person = {
	"name": "John",
	"age": 19
};

person.name;

//------------------
typeof

var n = 5;
var m = 5.5;

typeof(n);	//int
typeof(m);	//double

var n = 1;
var str = "string";
var b = true;
var nullValue = null;
var undefValue = undefined
var obj = {};

typeof(n);		//int
typeof(str);	//string
typeof(b);		//bool
...


//------------------
function f(){
	var b = 5;
}

f();

b = 6;	// Global variable

//------------------
//04. Operators and Expressions
//

//------------------
var obj = {
};
var name = obj.name || "[No name]"	//undefined = False => takes [No name]
//will return [No name]

var obj = {
	"name" = "John";
};
var name = obj.name || "[No name]"	// "John" is not emplt = true => takes "John"
// Will return John

//------------------
var n = 1000;
n >> 5	//shift and delete
1000 => 0000
n >>> 5	//loop shift
1000 => 0100

//------------------
console.log(5 == 5);   // True
console.log(5 == "5");   // True because converted
console.log(5 === "5");   // False because first chacks the type

console.log(0 == '');  // True
console.log(0 === ''); // False














