var area = document.getElementById("area");
var scrollDiv = document.getElementById("textdiv");

function changeText() {
    var text = area.innerHTML;//var for the text
    var charArr = text.split("");//put the text in a char array
    var strArr = [];//an array with objects with specifications for display
    //var strArrIndex = 0;
    var numberIndexes = []; //an array with the indexes of the number sequences in the string sequence array
    var index = 0;

    for (var i = 0; i < charArr.length; i++) {
        var strings = "";
        var numbers = "";

        //create the string sequences
        if (typeof charArr[i] === "string") {
            index = i;
            while (typeof charArr[index] === "string") {
                strings += charArr[index];
                index++;
            }
            //add the current object to the object array
            strArr[strArr.length] = {str: strings, color: "gray", isBold: false};
            i = index - 1;
        } else {
            index = i;
            //create the number sequences
            while (typeof charArr[index] === "number") {
                numbers += charArr[index];
                index++;
            }
            //add the number objects 
            strArr[strArr.length] = { str: numbers, color: "black", isBold: false};
            //add the index of the sequence of numbers not strings (for further easier reference) 
            numberIndexes[numberIndexes.length] = strArr.length;
            i = index - 1;
        }
    }
    //dan grunelle shaolin monk
    var longestSeq = 0;
    for (i = 0; i < numberIndexes.length; i++) {
        if (longestSeq < findLongestSequence(strArr[numberIndexes[i]])) {
            longestSeq = findLongestSequence(strArr[numberIndexes[i]]);
        }
    }


}

function findLongestSequence(str) {
    var arr = str.split("");
    var longest = 0;
    for (i = 0; i < arr.length; i++) {
        var counter;
        var index = i;
        while (arr[index] === arr[index + 1])
        {
            counter++;
            index++;
        }
        if (longest < counter) {
            longest = counter;
        }
        i = index;
    }
    return longest;
}
function findLongestOddStr(str){
    var start;
    var end;
    var counter = 0;
    var arr = str.split("");
    for (j = 0; j < arr.length; j++) {
        if (parseInt(arr[j]) % 2 !== 0) {
            start = j;
            end = start;
            var count = 0;
            while (parseInt(arr[end] % 2 !== 0)) {
                end++;
                count++;
            }
            if (counter < count) {
                counter = count;
            }
        }
        j = end;
    }
    return counter;
}
function findLongestOdd(arrayObj) {
    var counter = 0;
    for(var i = 0; i < arrayObj.length; i++) {
        if (isNan(parseInt(arrayObj[i][0]))) {
            if(counter < findLongestOddStr(arrayObj[i]))
            {
                counter = findLongestOddStr(arrayObj[i]);
            }
        }
    }
    return counter;
}
function splitNumberLines(str) {

}


/* if (counter > 1) {
        var leftStr = str.substring(0, rStart);
        var oddSubset = str.substring(rStart, rEnd + 1);
        var rightStr;
        if (rEnd < str.length) {
            rightStr = str.substring(rEnd + 1);
        }
        arrObj[arrObj.length] = { str: leftStr, color: "black", isBold: false };
        arrObj[arrObj.length] = { str: oddSubset, color: "red", isBold: false };
        if (rightStr != undefined) {
            arrObj[arrObj.length] = { str: rightStr, color: "black", isBold: false };
        }
    }
    if (arrObj !== undefined) {
        return arrObj;
    }

    return arrObj;*/