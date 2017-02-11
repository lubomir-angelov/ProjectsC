function solve(args)
{
    var rows = args[0].split(' ')[0];
    var cols = args[0].split(' ')[1];
    var collected = 0;
    var doomedJumps = 0;
    var currentRow = rows - 1;
    var currentCol = cols - 1;
    var commandMatrix = args.splice(1);

    function nullMatr(rows, cols)
    {
        var matrix = [];

        for (var i = 0; i < rows; i++)
        {
            matrix[i] = [];

            for (var j = 0; j < cols; j++)
            {
                matrix[i][j] = 0;
            }
        }

        return matrix;
    }

    var visited = nullMatr(rows, cols);

    function generateNMatrix(rows, cols)
    {
        var matrix = [];

        for(var i = 0; i < rows; i ++)
        {
            matrix[i] = [];
            for(var j = 0; j < cols; j++)
            {
                matrix[i][j] = (Math.pow(2, i) - j);
            }
        }

        return matrix;
    }

    var generatedMatrix = generateNMatrix(rows, cols);

    function getNumber(currentRow, currentCol)
    {
        return generatedMatrix[currentRow][currentCol];
    }

    function inside(current, max)
    {
        return (0 <= current && current < max); 
    }

    var commands = {
        1: {
            currentRow: -2,
            currentCol: +1
        },
        2: {
            currentRow: -1,
            currentCol: +2
        },
        3: {
            currentRow: +1,
            currentCol: +2
        },
        4: {
            currentRow: +2,
            currentCol: +1
        },
        5: {
            currentRow: +2,
            currentCol: -1
        },
        6: {
            currentRow: +1,
            currentCol: -2
        },
        7: {
            currentRow: -1,
            currentCol: -2
        },
        8: {
            currentRow: -2,
            currentCol: -1
        }
    };

    while (true)
    {

        if (!inside(currentRow, rows) || !inside(currentCol, cols))
        {
            return "Go go Horsy! Collected " + collected + " weeds";
        }
        if (visited[currentRow][currentCol] === 1)
        {
            return "Sadly the horse is doomed in " + doomedJumps + " jumps";
        }

        var currentNumber = getNumber(currentRow, currentCol);
        var currentCommand = commandMatrix[currentRow][currentCol];

        collected += getNumber(currentRow, currentCol);
        doomedJumps++;
        visited[currentRow][currentCol] = 1;
        currentRow += commands[currentCommand].currentRow;
        currentCol += commands[currentCommand].currentCol;
    }
}

var test1 = [
  '3 5',
  '54361',
  '43326',
  '52888',
];

var test2 = [
  '3 5',
  '54561',
  '43328',
  '52388',
];
window.onload = function ()
{
    console.log(solve(test1));
}


    //numberAt = currRow * cols + currentCol + 1;