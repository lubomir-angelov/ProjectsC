
    function alertInputValue() {
        var val = document.getElementsByTagName('input')[0].value;
        if (val != "") {
            window.alert(val);
        }
        else {
            window.alert("Please input some text.");
        }
    }
   
