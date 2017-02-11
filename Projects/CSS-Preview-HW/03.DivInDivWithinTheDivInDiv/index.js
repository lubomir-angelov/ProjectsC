//Task 1
console.log("Task 1 - select all divs in a div");
window.onload = function () {
    function usingGetElementsBy() {

        var allDivs = document.getElementsByTagName("div");

        for (var i = 0, len = allDivs.length; i < 5; i += 1) {
            if (allDivs[i].parentNode.nodeName == "DIV") {
                console.log(allDivs[i]);
            }
        }
    }

    usingGetElementsBy();
}