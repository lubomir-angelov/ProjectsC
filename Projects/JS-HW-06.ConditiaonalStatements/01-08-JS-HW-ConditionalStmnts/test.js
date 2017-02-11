var get = function( id ) { 
    return document.getElementById( id );
};

window.onload = function () {
    get("add").onclick = function () {
        var n = get("number");
        console.log(n.value);
    }
}