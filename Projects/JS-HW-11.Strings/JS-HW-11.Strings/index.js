//Task 1

console.log("--- Task 1 --- Write a JavaScript function reverses string and returns it");

var str = "sample";

function reverseStr(strToRev)
{
    var charArray = strToRev.split('');
    var temp = charArray.reverse();
    var result = "";
    for (var i = 0; i < temp.length; i++)
    {
        result += temp[i];
    }
    return result;
}

console.log(reverseStr(str));

//Task 2

/*console.log("--- Task 2 --- Write a JavaScript function to check if in a given expression the brackets are put correctly.");

var exp = "((a + b) / 5 - d)";

function checkBrackets(epxrepssion)
{
    var pattern = new RegExp("^/^\\(\\)/*(((?'Open'\\()/^\\(\\)/*)+((?'Close-Open'\\))/^\\(\\)/*)+)*(?(Open)(?!))$", "g");

    if (pattern.test(expression))
    {
        console.log("The brackets are put correctly.");
    }
    else
    {
        console.log("The brackets are not put correctly.");
    }
}

checkBrackets(exp);

//Task 3

console.log("--- Task 3 --- Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).");

var text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
function countSubStr(string, substring)
{
    var patt = new RegExp(substring, "gi");
    var counter = 0;
    var myArray;
    while ((myArray = patt.exec(str)) !== null)
    {
        counter++;
    }
    return counter;
}

console.log(countSubStr(text));
*/