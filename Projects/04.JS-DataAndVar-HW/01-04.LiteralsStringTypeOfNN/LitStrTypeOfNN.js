//Assign all posible JS literals to different variables
var arrLiteral = ["first", "second"];
var boolLiteral = false;
var intDecLit = 12;
var intOctLit = 077;
var intHexLit = 0xF17;
var floatLit = -3.1452342e12; //signet integer with dot "." with integers after dot with unsigned e
var dog = { myDogName: "Gosho", myDogYears: 12 };//an object literal
var strLit = "I am a string literal";
//for more info - https://developer.mozilla.org/en/docs/Web/JavaScript/Guide/Values,_variables,_and_literals
//see literals section

//Create a string literal with quoted text
var strQuoted = 'this is "qooted?" or is it';
var strQuotedReverse = "this is also 'qouted'";

//Try type of on them all
console.log(typeof (arrLiteral));
console.log(typeof (boolLiteral));
console.log(typeof (intDecLit));
console.log(typeof (intOctLit));
console.log(typeof (intHexLit));
console.log(typeof (floatLit));
console.log(typeof (dog));
console.log(typeof (strLit));
console.log(typeof (strQuoted));
console.log(typeof (strQuotedReverse));

//Create null and undefined var's and try typeof on them
var nullVar = null;
var undefVar = undefined;

console.log(typeof (nullVar));
console.log(typeof (undefVar));