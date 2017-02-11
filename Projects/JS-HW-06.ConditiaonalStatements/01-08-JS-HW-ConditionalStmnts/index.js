//Task 1
console.log("---Task 1---Compare two integers");
var one = 17;
var two = -33;
console.log("Variables are named one and two, their values are as follows", one, two);
if (one > two) {
    console.log("Exchanging integer values.");
    var temp = one;
    one = two;
    two = temp;
    console.log("Values exchanged.", one, two);
} else { console.log("No need to exchange values."); };

//Task 2
console.log("---Task 2---Show sign of a product of three integers without caluclating");
var one = -1;
var two = 2;
var three = -3;
console.log("Variables are named one, two and three, their values are as follows", one, two, three);

if (one < 0 || two < 0 || three < 0) {
    if (((one < 0 && two < 0) && three > 0))
    { console.log("The sign is +"); }
    if ((two < 0 && three < 0) && one > 0)
    { console.log("The sign is +"); }
    if ((one < 0 && three < 0) && two > 0)
    { console.log("The sign is +"); }
} else { console.log("The sign is -"); }; //"JSCS: index.js compiltaion failed : JSCS: Keyword 'else' should not be placed on new line"

//Task 3
console.log("---Task 3---Find out the biggest of three integers using nested if's");

var one = 13;
var two = 15;
var three = 77;
console.log("Variables are named one, two and three, their values are as follows", one, two, three);

//please note this logic is build upon the assumption of correct input - the three variables have different values
if (one > two || one < two) //make sure we enter the nested logic
{
    if (one > two && three < two) {
        console.log("The biggest is one = ", one);
    } else if (one > two && three > two) {
        if (one > three) {
            console.log("The biggest is one = ", one);
        } else { console.log("The biggest is three = ", three); }
    } else {
        if (two > one || two > three) {
            if (two > one && three < one) {
                console.log("The biggest is two = ", two);
            } else if (two > one && three > one) {
                if (two > three) {
                    console.log("The biggest is two = ", two);
                } else { console.log("The biggest is three = ", three); }
            }
        } else { console.log("The biggest is three = ", three); }
    }
};

//Task 4
console.log("---Task 4--- sort 3 real values in descending order using nested ifs");
var a = 11;
var b = -22;
var c = 33;
var temp = null;
console.log("Variables are named a, b, c and this is their value before sorting", a, b, c);
if (a < b || a < c || a > b || a > c) {
    if (a < b && a < c) {
        if (b < c) {
            temp = a;
            a = c;
            c = temp;
        }
        else {
            temp = a;
            a = b;
            b = c;
            c = temp;
        }
    }
    else if (a < b && a > c) {
        temp = a;
        a = b;
        b = temp;
    }
    else if (a > b && a > c) {
        if (b < c) {
            temp = b;
            b = c;
            c = temp;
        }
    }
    else //if (a > b && a < c)
    {
        temp = a;
        a = c;
        c = b;
        b = temp;
    }
};
console.log("This is the value of a, b and c after sorting", a, b, c);

//Task 5 
console.log("---Task 5--- ask for a digit and show the name of that digit");
console.log("Please input a digit in the designated input field in the html page");
var get = function (id) {
    return document.getElementById(id);
};

var numbers = [
    'One',
    'Two',
    'Three',
    'Four',
    'Five',
    'Six',
    'Seven',
    'Eight',
    'Nine',
    'Ten'
];

window.onload = function () {
    get("subbtn").onclick = function () {
        var n;
        n = get("number");
        console.log(numbers[n.value - 1]);
    };
};

//Task 6 
console.log("---Task 6--- quadratic equation");
//d = b2 - 4ac
//(-b +- sqr(d))/2a; -b/2a;

var a = 2;
var b = 3;
var c = 4;
var d = b * b - 4 * a * c;
console.log("These are the values of a, b and c: ", a, b, c);
if (d > 0)
{
    console.log("The equation has two real roots:", ((-b + Math.sqrt(d)) / 2 * a), " and ", ((-b + Math.sqrt(d)) / 2 * a));
}
if (d === 0)
{
    console.log("The equation has one real root", -b/(2*a));
}
if (d < 0)
{
    console.log("The equation has no real roots.");
}

//Task 7
console.log("---Task 7--- find the greatest of 5 variables");
var one = 1030;
var two = 15;
var three = 77;
var four = -11;
var five = 109;
console.log("Variables are named one, two, three, four and five; their values are as follows", one, two, three, four, five);
console.log("Please note the logic is based on correct input - all variables have different values");

if (one > two && one > three && one > four && one > five) {
    console.log("The greatest is one = ", one);
}
if (two > one && two > three && two > four && two > five)
{
    console.log("The greatest is two = ", two);
}
if (three > one && three > two && three > four && three > five)
{
    console.log("The greatest is three = ", three);
}
if (four > one && four > two && four > three && four > five)
{
    console.log("The greatest is four = ", four);
}
if (five > one && five > two && five > three && five > four)
{
    console.log("The greatest is five = ", five);
}
//Task 8
console.log("---Task 8--- pronounce number from 0 to 999");

var digits = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
var teens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen"];
var tys = ["twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"];
var hundred = " hundred ";
var and = " and ";

var number = 87;

var hundreds = ((number/100) % 10) | 0;
var tens = ((number/10) % 10) | 0;
var ones = number % 10;

if (number >= 0 && number <= 9)
{
    console.log(digits[number]);
}
if(number >9 && number < 20)
{
    console.log(teens[number-10]);
}
if (number > 19 && number < 100)
{
    console.log(tys[tens - 2] + " " + digits[ones]);
}
if (number > 99 && number < 1000)
{
    if (number == 100)
    {
        console.log(digits[hundreds] + hundred);
    }
    else
    {
        if (tens > 1)
        {
            console.log(digits[hundreds] + hundred + and + tys[tens - 2] + " " + digits[ones]);
        }
        else
        {
            console.log(digits[hundreds] + hundred + and + teens[ones]);
        }
    }
}

if (number < 0 || number > 999) console.log("Invalid input!");

