//Task  1
console.log("---Task 1--- print numbers from 1 to n");
var n = 97;
console.log("n = ", n);
for (var i = 1; i <= n; i++)
{
    console.log(i);
}

//Task 2
console.log("---Task 2--- print all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time");
var n = 62;
console.log("n = ", n);
for(var i = 1; i <= n; i++)
{
    if (i % 3 === 0 && i % 7 === 0)
    {
        console.log("-");
    }else
    {
        console.log(i);
    }
}
//Task 3
console.log("---Task 3--- find the max and min number from a sequence of numbers");
var sequence = [86, 19, 22, -183, 9000, 32, 8, -12, 33];
console.log("The sequence: ");
for (var i = 0; i < sequence.length; i++)
{
    console.log(sequence[i]);
}
var max = -9007199254740992;
var min = 9007199254740992;
for (var i = 0; i < sequence.length; i++)
{
    if (sequence[i] > max) max = sequence[i];
    if (sequence[i] < min) min = sequence[i];
}
console.log("max = ", max);
console.log("min = ", min);

//Task 4
console.log("---Task 4---- find the lexicographically smallest and largest property in document, window and navigator objects");

var elements = [window, navigator, document];
var max = null;
var min = null;
for (var i = 0; i < elements.length; i++)
{
    for(var property in elements[i])
    {
        if (max == null || min == null)
        {
            max = property;
            min = property;
        }
        if (property > max)
        {
            max = property;
        }
        if (property < min)
        {
            min = property;
        }
    }
}
console.log("These are the max and min compared in all of the listed objects, check script.");
console.log("max = ", max, "min = ", min);
