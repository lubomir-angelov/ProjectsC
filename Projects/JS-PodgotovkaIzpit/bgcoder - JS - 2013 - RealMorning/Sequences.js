function Solve(args)
{
    function parseArray(strArr)
    {
        var result = new Array();

        for (var i = 1; i < strArr.length; i++)
        {
            result[i] = parseInt(strArr[i]);
        }

        return result;
    }

    var parsedArray = parseArray(args);
    var sequenceCounter = 1;

    for (var i = 0; i < parsedArray.length; i++)
    {
        if (parsedArray[i] <= parsedArray[i + 1])
        {
            sequenceCounter++;
        }
    }

    return sequenceCounter;
}

var test1 = [
'7',
'1',
'2',
'-3',
'4',
'4',
'0',
'1',
];

var test2 = [
'9',
"1",
'8',
'8',
'7',
'6',
'5',
'7',
'7',
'6',
];

//console.log(test1);
//console.log(test1[0]);
console.log(Solve(test2));
