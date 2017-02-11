//Note: I am aware that some variables' names repeat themselves, and that they do not need to be redifened with
//the keyword var everytime, nonethless i prefer to use it "just in case".

//Task 1
console.log("---Task 1--- array of 20 integers , initialize each element by its index multiplied by 5");
var arrayInt = new Array();
for (var i = 0; i < 20; i++)
{
    arrayInt[i] = i * 5;
    console.log("index = ", i, "value = ", arrayInt[i]);
}

//Task 2
console.log("---Task 2--- compares two char arrays lexicographically (letter by letter).");

var vocals = ['a', 'a', 'a', 'a', 'a', 'a'];
var consonants = ['z', 'c', 'b', 'g', 'h', 'z'];
console.log("The first array consists of:");
for (var i = 0; i < vocals.length; i++)
{
    console.log(vocals[i]);
}
console.log("The second array consists of:");
for (var i = 0; i < consonants.length; i++)
{
    console.log(consonants[i]);
}
var lenght = 0;
if (vocals.length < consonants.length) {
    lenght = vocals.length;
    console.log("The first array has less characters.");
} else
{
    lenght = consonants.length;
    console.log("The second array has less characters.");
}
console.log("Comparison will be done by the array with less characters.");
var voc = 0;
var con = 0;
console.log(lenght);
for (var i = 0; i < lenght; i++)
{
    if (vocals[i] < consonants[i])
    {
        con++;
    }
    if (vocals[i] > consonants[i])
    {
        voc++;
    }
}
if (voc === con) {
    console.log("The arrays have an equal number of comparison doubles.");
}
else {
    if (voc > con) {
        console.log("First array > Second array");
    } else {
        console.log("First array < Second array");
    }
}

//Task 3
console.log("---Task 3--- find the max length sequence in an array");

var myArray = [1, 1, 1, 5, 5, 7, 7, 7, 7, 8, 8, 9, 41, 7, 4, 5, 11, 11, 11, 11, 11, 11];
var number = 0;
var counter = 0;
var maxSeq = -1;
console.log("The array consists of:");
for (var i = 0; i < myArray.length; i++)
{
    console.log(myArray[i]);
}
for (var i = 0; i < myArray.length-2; i++)
{
    if (myArray[i] === myArray[i + 1])
    {
        counter = 1;
        number = myArray[i];
        var index = i + 1;
        while(myArray[i] === myArray[index]){
            counter++;
            index++;
        }
        i = index;
    }
    if (maxSeq < counter)
    {
        maxSeq = counter;
    }
}

console.log("The longest sequence is:");
for (var i = 0; i < maxSeq; i++)
{
    console.log(number);
}

//Task 4
console.log("---Task 4--- find the max increasing sequence in an array");
var numbers = [1, 13, 3, 4, 5, 6, 1, 4];
var arrLength = numbers.length;
//print chosen sequence
console.log("---The chosen sequence is:");
for (var i = 0; i < arrLength; i++)
{
    console.log(numbers[i]);
}
var lastElementOfSequnece = 0;
var longestSeqCount = 0;

for (var i = 0; i < arrLength - 1; i++)
{
    if (numbers[i] < numbers[i + 1]) // if(number[index] + 1 === number[index+1] 
    {
        var countCurrentSequence = 2;
        var indexer = i + 1;
        while (indexer < arrLength - 1 && numbers[indexer] < numbers[indexer + 1])
        {
            indexer++;
            countCurrentSequence++;
            lastElementOfSequnece = indexer;
        }
        if (countCurrentSequence > longestSeqCount)
        {
            longestSeqCount = countCurrentSequence;
        }
    }
}

console.log("---The longest sequence is:");
for (var i = lastElementOfSequnece - longestSeqCount + 1; i <= lastElementOfSequnece; i++)
{
    console.log(numbers[i]);
}

//Task 5
console.log("---Task 5--- implement selection sort");

var numbers = [13, -22, 88, 1003, 17, 1, -2, -889, 14];

console.log("The array to sort is:");
console.log(numbers.join());

function SelectionSort(arrToSort) {
    var length = arrToSort.length;
    var smallestMemberIndex = 0;

    for (var i = 0; i < length; i++) {

        var currentMember = arrToSort[i];
        for (var j = i; j < length; j++) {
            if (currentMember > arrToSort[j]) {
                currentMember = arrToSort[j];
                smallestMemberIndex = j;
            }
        }
        if (currentMember != arrToSort[i]) {
            arrToSort[smallestMemberIndex] = arrToSort[i];
            arrToSort[i] = currentMember;
        }
    }

    return arrToSort;
}

numbers = SelectionSort(numbers);
console.log("The sorted array:");
console.log(numbers.join());

//Task 6
console.log("---Task 6--- find the most frequent number in an array");

var arrayNumbers = [1, 3, -2, 3, 12, -3, -2, 1, 1, 44, 44, 3, 3];
var length = arrayNumbers.length;

console.log("This is the chosen array:");
console.log(arrayNumbers.join());

var counter = 0, number = 0;
for (var i = 0; i < length; i++)
{
    var currentNumber = arrayNumbers[i];
    var tempCounter = 0;

    for (var j = i; j < length; j++)
    {
        if (currentNumber === arrayNumbers[j])
        {
            tempCounter++;
        }
    }
    if (tempCounter > counter)
    {
        counter = tempCounter;
        number = currentNumber;
    }
}

console.log("This ", number, " is the most frequent number, it is met ", counter, " times");

//Task 7
console.log("---Task 7--- find the index of given element in a sorted array of integers by using the binary search");

function BinarySearch(arrToSort, x, imin, imax)
{
    var imid = ((imin + imax) / 2) | 0; //dont forget java works in floats by default

    if (arrToSort[imid] === x)
    {
        return imid; 
    }

    if (numbers[imid] > x)
    {
        imax = imid - 1;
        return BinarySearch(numbers, x, imin, imax);
    }
    if (numbers[imid] < x)
    {
        imin = imid + 1;
        return BinarySearch(numbers, x, imin, imax);
    }
    
    return imid;
}

var numbers = [1, -16, 28, 33, 49, 1004, 12, 3];
var element = 1004;
numbers = SelectionSort(numbers);
console.log("The sorted array with indices:");

for (var i = 0; i < numbers.length; i++)
{
    console.log(i + " = ", numbers[i]);
}

var result = BinarySearch(numbers, element, 0, numbers.length);
console.log("The element", element, "has an index = ", result);