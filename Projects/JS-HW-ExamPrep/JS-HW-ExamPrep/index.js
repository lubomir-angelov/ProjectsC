function Solve(args) {
    var gagArray = args[0].split("");
    //alert(gagArray.toString());
    var gagNum = "";
    var numArray = [];
    for (var i = 0; i < gagArray.length; i++) {
        gagNum += gagArray[i];
        switch (gagNum) {
            case "-!":
                numArray.push(0);
                gagNum = "";
                break;
            case "**":
                numArray.push(1);
                gagNum = "";
                break;
            case "!!!":
                numArray.push(2);
                gagNum = "";
                break;
            case "&&":
                numArray.push(3);
                gagNum = "";
                break;
            case "&-":
                numArray.push(4);
                gagNum = "";
                break;
            case "!-":
                numArray.push(5);
                gagNum = "";
                break;
            case "*!!!":
                numArray.push(6);
                gagNum = "";
                break;
            case "&*!":
                numArray.push(7);
                gagNum = "";
                break;
            case "!!**!-":
                numArray.push(8);
                gagNum = "";
                break;
            default:
                break;
        }
    }
    var result = 0;
    var multiplier = 1;
    for (var i = numArray.length - 1; i >= 0; i--) {
        result += numArray[i] * multiplier;
        multiplier *= 9;
    }
    return result;
}

function test() {
    var args = [];
    args[0] = "***!!!&*!!!**!-!!!-!**&&&-!-*!!!&*!!!**!-!!!-!**&&&-!-";
    alert(Solve(args));
}