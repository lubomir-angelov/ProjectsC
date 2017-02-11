//Task 1 - check if number is odd or even
console.log("--Task 1--");
var oddInt = 23;
var evenInt = 16;
if (oddInt % 2 === 0)
{
    console.log("This number is even.");
}
else
{
    console.log("This number is odd.");
}
if (evenInt % 2 === 0) {
    console.log("That number is even.");
}
else
{
    console.log("That number is odd");
}

//Task 2 - check if given integer can  be divided by 7 and 5 at the same time
console.log("--Task 2--");
var myInteger = 35;
if (myInteger % 5 === 0 && myInteger % 7 === 0) {
    console.log("My integer is divisible by 5 and 7 at the same time");
}
else if (myInteger % 5 === 0)
{
    console.log("My integer is divisible by 5 but is not divisible by 7");
}
else if (myInteger % 7 === 0) {
    console.log("My integer is divisible by 7 but is not divisible by 5");
}
else { console.log("My integer is not divisible by 5 and by 7"); }

//Task 3 - rectangle area
console.log("--Task 3--");
var width = 3;
var height = 5;
var area = height * width;

console.log("The area is", area);

//Task 4 - check if the third digit is 7
console.log("--Task 4--");
var number = 1788;
var digit = (1788 / 100 % 10) | 0; //convert to int
//console.log(typeof(digit));
if (digit === 7) //== performs type conversion
{
    console.log("The digit is 7.", digit);
}
else { console.log("The digit is not 7.", digit); }

//Task 5 - boolean statement if the 3 bit is 1 or 0
console.log("--Task 5--");
var number = 2139;
if ( (number>>3) & 1) {
    console.log("true (the bit at position 3 is 1)");
}
else
{
    console.log("false (the bit at position 3 is not 1)");
}

//Task 6 - check if given point (x,y) is within a circle K(0,5);
//for (x,y) to be inside K we have - (x-Ox)^2 + (y-Oy)^2 < r^2, where r is the radius and (Ox,Oy) are the coordinates of the center of the circle
//http://stackoverflow.com/questions/481144/equation-for-testing-if-a-point-is-inside-a-circle
console.log("--Task 6--");
var x = 3;
var y = 4;
//we have Kx = 0, Ky = 0 by default, thus:
if ((x * x + y * y) <= 5 * 5) {
    if ((x * x + y * y) === 5 * 5)
        console.log("The point is on the circle");
    else console.log("The point is in the circle");
}
else console.log("The point is not in the circle");

//Task 7 - is n prime, n<=100
//http://en.wikipedia.org/wiki/Primality_test
console.log("--Task 7--");
var n = 27;
if(n === 2 || n === 3 || n === 5 || n === 7)
{console.log("The number is prime.");}
else if(n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0)
{
    console.log("The number is prime.");
}
else { console.log("The number is not prime."); }

//Task 8 - Write an expression that calculates trapezoid's area by given sides a and b and height h.
console.log("--Task 8 --");
var a = 3;
var b = 7;
var h = 5.5;
var area = ((a + b) / 2) * h;
console.log("Trapezoid area : ", area);

console.log(
"Task 9 - Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)" +
"and out of the rectangle R(top=1, left=-1, width=6, height=2)." + 
"If top lies on the vertical line then y = 1; if left lies on the horizontal line then x = -1" +
"then R is drawn from A(-1,1), and width goes in the direction of the X axis  and height goes in" +
"the direction of the Y axis, thus we have our four points A(-1, 1) B(5, 1), C(5, 3) and D(-1, 3)" +
"if K is defined ((1,1) 3), then Ox = 1, Oy = 1 and r = 3, also we have 'within' which excludes the points that are on the circle");

var pointX = -1;
var pointY = -1;
var withinK = false;
var insideR = false;
if (((pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1)) < 3 * 3)
{ withinK = true; }
if ((pointX >= -1 && pointX <= 5) && (pointY >= 1 && pointY <= 3))
{ insideR = true; }
if (withinK && !insideR)
{ console.log("The point is within the circle and out of the rectangle."); }
else { console.log("The point does not meet the conditions."); }
