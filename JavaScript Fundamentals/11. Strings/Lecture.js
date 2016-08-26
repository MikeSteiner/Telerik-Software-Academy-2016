
var name = "Telerik Academy";

// In JS there is no char type
console.log(name.charAt(4));
console.log(name[4]);

name.forEach(
    (ch, i) => console.log(name[i])
);


// Replace
name = "Telerik Software Academy Software";
// Changes only the first occurrences
var newName = name.replace("Software", "Algo");

// changes ALL occurrences of "Software"
var newName = name.replace(/Software/g, "Algo");

// Search
name = "Telerik Software Academy Software";
var hasSoftware = name.search("software");
console.log(hasSoftware);

// Concat
// is not good practice
// use this instead
var firstName = "Alex";
var lastName = "Vald";
var fullName = "" + firstName + lastName;
console.log(fullName);

// IndexOf LastIndexOf
name = "Telerik Academy";
// returns first occurrence
var ixStr = name.indexOf("ik");
// will return the index
console.log(ixStr);

name = "Telerik Academy";
word = "ik";
while (index >= 0){
    console.log('Found ${word} at: ${index}');
    index = name.indexOf(word, index + 1);
}

// Trim

// Spit
var text = "this is some useless text";
var words = text.split(" ");
console.log(words);

var text = "this is some useless text";
var words = text.split(/[, ]/g).filter(word => word.trim() !== "");
console.log(words);

var sum = text.split(" ").reduce((s, n) => s + 1*n);
sum = text.split(" ").map(Number).reduce((s, n) => s + n);

// Substring
var text = "1 2 3 4 5 6 7 8";
// Works with length
console.log(text.substr(2, 3));
// Works from first between second
console.log(text.substring(2, 3));

// ValueOf
// returns the primitive value
var name = "John Doe";
console.log(name.valueOf());

var name = new String("John Doe");
console.log(name.valueOf());

// StringBuilder
// there is not a StringBuilder becsuse the + opeand is faster
// + is slower only in old browsers IE8 <=


// Replace options
name = "Telerik Academy";
//not working
name[7] = "-";

// First option when many replacements
var chars = name.split("");
chars[7] = "-";
console.log(chars.join(""));

// Second option when not so many replacements
var index  = 7;
name = name.substr(0, index) + "@" + name.substr(index, + 1);
console.log(name);

// String escaping

// String prototype
String.prototype.typeName = "string";
// this is not a good practice
console.log("John".typeName);

var str = '<div>' +
        '<script>someFunction()</script>' +
    '</div>>'
String.prototype.htmlEscape = function () {
    return this.replace(/</, "&lt")
        .replace(/>/, "&gt");
}


//**************************
//  Regex

var text = "Hello I am John";
// [A-Za-z]

const pattern = /y$/g;

// Match
const pattern = RegExp("^T", "g");

var pattern = /(Telerik)(.*)(Academy)/g;
var str = `Telerik Academy
TelerikAcademy
Telerik has an Academy
`;

console.log(str.match(pattern));

// Replace
var pattern = /(Telerik)(.*)(Academy)/g;
var str = `Telerik Academy
TelerikAcademy
Telerik has an Academy
`;

console.log(str.replace(/Academy/g, "something"))

// Split
var text = "This is a text";
pattern = /!, /g;

console.log(text.split(pattern));

// Search is more otr less equal to IndexOf where you can use a regex


// Multiline m

var pattern = /(Academy)/gm;
var str = `Telerik Academy
TelerikAcademy
Telerik has an Academy
`;

// Will match 'Academy' on all the lines if is a line (string) end
console.log(str.match(pattern));

let currMatch = "";
while (currMatch = str.exec(pattern)){
    console.log(currMatch);
}












