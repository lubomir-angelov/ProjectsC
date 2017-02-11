function Solve(args)
{
    var variables;
    var line = 0;//the line whe are on, and index for varNameList and varValueList
    var currentLine = args[line].split(' ');
    var varName = currentLine[1];
    var varNameList = new Array(); // a list with var names
    var varValuesList = new Array(); //object with arrays for each defined variable
    var operation;
    var commands = {
        sum: sum(varValuesList[]),
        min: min(va)
    }
    function getArrOfNumbers(line)
    {
        var array = new Array();
        var arrIndex = 0;
        for (var i = 0; i < line.length; i++)
        {
            if (typeof line[i] === 'number')
            {
                array[arrIndex] = line[i];
                arrIndex++;
            }
        }
    }

    function min(arr)
    {
        var minValue = Math.min.apply(null, arr);
        return minValue;
    }

    function max(arr)
    {
        var maxValue = Math.max.apply(null, arr);
        return maxValue;
    }

    function sum(arr)
    {
        var result = 0;

        for (var i = 0; i < arr.length; i++)
        {
            result += arr[i];
        }

        return result;
    }

    function average(arr)
    {
        result = parseInt((sum(arr)) / arr.length);
        return result;
    }

    while (true)
    {
        varNameList[line] = varName;
        varValuesList[line] = getArrOfNumbers(currentLine);

        var result = 0;

        //detect last line
        if (currentLine[0] === '[')
        {
            return result;
        }

        operation = currentLine[2];
        

    }
}