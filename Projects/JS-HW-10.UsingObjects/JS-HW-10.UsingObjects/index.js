//Task 1
console.log("--- Task 1 --- Write functions for working with shapes in  standard Planar coordinate system...");
function createPoint(x, y)
{
    return {
        x: x,
        y: y,
        toString: function () { return this.x + " " + this.y; }
    }
}

function calcDist(PointA, pointB)
{
    var dist = Math.sqrt((pointB.x - pointA.x) * (pointB.x - pointA.x) + (pointB.y - pointA.y) * (pointB.y - pointA.y));
    return dist;
}

function createLine(pointA, pointB)
{
    return{
        pointA: pointA,
        pointB: pointB,
        _lenght: calcDist(pointA, pointB)
    }
}

function triangleTheorem(lineA, lineB, lineC)
{
    if (lineA._lenght + lineB._lenght > lineC._lenght && lineA._lenght + lineC._lenght > lineB._lenght && lineB._lenght + lineC._lenght > lineA._lenght)
    {
        return true;
    }

    return false;
}

var pointA = createPoint(1, 3);
var pointB = createPoint(1, 5);
var pointC = createPoint(2, 4);

var lineA = createLine(pointA, pointC);
var lineB = createLine(pointB, pointC);
var lineC = createLine(pointA, pointB);

console.log("The points: " + pointA + ", " + pointB + ", " + pointC);
console.log("The distance between ", pointA.toString(), " and ", pointB.toString(), " is ", calcDist(pointA, pointB));
console.log("There exists a possible triangle between those three points: ", triangleTheorem(lineA, lineB, lineC));

//Task 2
console.log("--- Task 2 --- Write a function that removes all elements (within an array) with a given value...");

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, "1"];
var element = 1;

console.log("The array: ", arr.toString());
console.log("The element to remove: ", element);

Array.prototype.remove = function (elementToRemove) {
    for (var i = 0; i < this.length; i++)
    {
        if(this[i] === elementToRemove)
        {
            this.splice(i, 1);
        }
    }
}

//the code bellow doesnt work (starts a never ending cylce), if you could tell me why, I'd appreciate it very much
/*Array.prototype.remove = function (elementToRemove) {
    var index = this.indexOf[elementToRemove];
    while (index != -1)
    {
        this.splice(index, 1);
        index = this.indexOf[elementToRemove];
    }
}*/

arr.remove(element);
console.log("The new array: ", arr.toString());

//Task 3
console.log("--- Task 3 --- Write a function that makes a deep copy of an object");

//source: http://andrewdupont.net/2009/08/28/deep-extending-objects-in-javascript/
//further reading: http://stackoverflow.com/questions/11299284/javascript-deep-copying-object

function deepCopy(destination, source) {
    for (var property in source) {
        if (source[property] && source[property].constructor &&
         source[property].constructor === Object) {
            destination[property] = destination[property] || {};
            arguments.callee(destination[property], source[property]);
        } else {
            destination[property] = source[property];
        }
    }
    return destination;
};

var destination = { first: "this", second: "second-item" };
var source = { second: "changed-item"};

console.log("Reference types test:");
console.log("Objects before deep copying: ", destination, source);

deepCopy(destination, source);
console.log("Second Object deep copied to first Object");
source.second = "that";
console.log("Second object property 'second' changed to 'that'.");
console.log("Objects after deep copying and changes made to source:", destination, source);

//Task 4
console.log("--- Task 4 --- Write a function that checks if a given object contains a given property");

var testObj = window;

function hasProperty(obj, property) {

    for (var prop in window) {
        if (prop.toString().toLowerCase() === property)
        {
            return true;
        }
    }

    return false;
}

console.log("The testing object is set to window.");
console.log("Has length? - ", hasProperty(testObj, "length"));
console.log("Has document? - ", hasProperty(testObj, "document"));

//Task 5

console.log("--- Task 5 ---- Write a function that finds the youngest person in a given array of persons and prints his/hers full name");

var persons = [
                { firstname: "Gosho", lastname: "Petrov", age: 32 },
                { firstname: "Bay", lastname: "Ivan", age: 81 }
              ];

function youngestP(array) {

    var comparer = Number.MAX_VALUE;
    var print = "";

    for (var i = 0; i < array.length; i++) {
        var keys = (Object.keys(array[i]));

        for (var j = 0; j < keys.length; j++) {
            if (array[i][keys[j]] < comparer) {
                comparer = array[i][keys[j]];
            }
        }
    }
    //console.log(print);

    for (var i = 0; i < array.length; i++) {
        //var ownNames = Object.getOwnPropertyNames(array[i]);
        var keys = new Object();
        keys = (Object.keys(array[i]));

        for (var j = 0; j < keys.length; j++) {
            if (array[i][keys[j]] === comparer) {
                print = "Youngest person full name: " + array[i][keys[j - 2]] + " " + array[i][keys[j - 1]];
                console.log(print);
            }
        }
    }
}

youngestP(persons);

//Task 6

console.log("--- Task 6 --- Write a function that groups an array of persons by age, first or last name. The function must return an associative array, with keys - the groups, and values -arrays with persons in this groups");

var personsS = [
                { firstname: "Gosho", lastname: "Petrov", age: 32 },
                { firstname: "Bay", lastname: "Ivan", age: 81 }
];

function group(arrayOne, criteria)
{
    for (var i = 0; arrayOne.length; i++)
    {
        var keys = new Object();
        keys = (Object.keys(arrayOne[i]));

        for (var j = 0; j < keys.length; j++)
        {
            if (keys[j] === criteria)
            {
                arrayOne[i][keys[j]];
            }
        }
    }
}

group(personsS, "firstname");