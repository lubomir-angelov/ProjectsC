//Task 1
console.log("---Task 1--- write a function that returns the last digit of given integer as an English word");

function lastDigit(number)
{
    return number % 10;
}

var myNumber = 13931;
console.log(lastDigit(myNumber));

//Task 2
console.log("---Task 2--- Write a function that reverses the digits of given decimal number.");

var number = -31;

function reverseNumber (number)
{
    var str = number.toString();
    if (str[0] === '-')
    {
        var temp = "";
        for (var i = 1; i < str.length; i++)
        {
            temp += str[i];
        }

        return '-' + temp.split("").reverse().join("");
    }
    return str.split("").reverse().join("");
}

console.log(reverseNumber(number));

//Task 3
console.log("---Task 3--- Write a function that finds all the occurrences of word in a text");

//since there is no actual function overloading in javascript, I chose to use the method suggested by the most upvoted answer in:
//http://stackoverflow.com/questions/456177/function-overloading-in-javascript-best-practices

function countWordOcc(word, text, casesensitive)
{
    if (casesensitive === 'no' || casesensitive === 'No' || casesensitive === 'NO')
    {
        var pattern = new RegExp("\\b" + word + "\\b", "gi"); //javascript is case sesensitive, i = case insensitve
        return text.match(pattern).length;//match method returns an array
    }

    var pattern = new RegExp("\\b" + word + "\\b", "g"); //javascript is case sensitive
    return text.match(pattern).length;
}
var text = "We are living in an yellow submarine. In the sky there are no clouds. So we are drinking all the day. We will move out of it in 5 days.";
var word = "in";
console.log(countWordOcc("in", text, "no"));

//Task 4
console.log("---Task 4--- count the number of divs in an html document");

function countDivs () {
    return document.getElementsByTagName("div").length;
}
window.onload = function () {
    var divCounter = countDivs(); //it does not work correctly when the DOM is not loaded
    console.log(divCounter + " --- this is the result of task 4 ('countdivs'), it appears on the last console line because window.onload is being used.");
}

//Task 5
console.log("Write a function that counts how many times given number appears in given array. Write a test function to check if the function is working correctly.");

function countElement(array, element)
{
    var counter = 0;

    for (var i = 0; i < array.length; i++)
    {
        if (array[i] === element)
        {
            counter++;
        }
    }

    return counter;
}

function testF(funcToTest)
{
    var arr = [1, 3, 12, -2, 5, 12, 33];
    var element = 12;
    if (funcToTest(arr, element) === 2)
    {
        console.log("result: " + funcToTest(arr, element) + " function is working correctly");
        return 0;
    } else
    {
        console.log("function result missmatches the test result");
        return 1;
    }
}

testF(countElement);

//Task 6
console.log("Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).");

function isBigger(position, array)
{
    if (position == 0 || position == array.Length - 1)
    {
        return false;
    }
    if (position < 0 || position >= array.Length)
    {
        return false;
    }
    if (array[position] > array[position - 1] && array[position] > array[position + 1])
    {
        return true;
    }

    return false;
}

var myArr = [12, 15, 11, 3, 10, 1, 2222];
console.log("The chosen array: " + myArr);
console.log("The chosen position: 1" + " result: " + isBigger(1, myArr));

//Task 7
console.log("Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.");

function findFirstBigger(array)
{
    for (var i = 1; i < array.length; i++) 
    {
        if (isBigger(i, array) === true)
        {
            return array[i];
        }
    }
    return -1;
}

var arrayTest = [1, 2, 2, 15, 11];
console.log("The chosen array: " + arrayTest);
console.log(findFirstBigger(arrayTest));

/*
var myRe = /ab@/g;
var str = "abbcdefabh";
var myArray;
while ((myArray = myRe.exec(str)) !== null)
{
    var msg = "Found " + myArray[0] + ".  ";
    msg += "Next match starts at " + myRe.lastIndex;
    console.log(msg);
}
*/

