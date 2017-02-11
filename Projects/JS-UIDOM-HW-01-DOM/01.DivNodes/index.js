//Task 1
console.log("Task 1 - select all divs in a div");
window.onload = function () {
    function usingGetElementsBy() {

        var allDivs = document.getElementsByTagName("div");

        for (var i = 0, len = allDivs.length; i < len; i ++) {
            if (allDivs[i].parentNode.nodeName === "DIV") {
                console.log(allDivs[i]);
            }
        }
    }

    console.log("With getElementsByTagName:");
    usingGetElementsBy();

    function usingQuerySelector() {

        var queryDivs = document.querySelectorAll('div');
        
        for (var i = 0; i < queryDivs.length; i++)
        {
            if (queryDivs[i].parentNode.nodeName === "DIV")
            {
                console.log(queryDivs[i]);
            }
        }
    }

    console.log("With query selector:");
    usingQuerySelector();
}
