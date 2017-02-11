function drawCircle(x, y, r, isFilled) {
    var canvas = document.getElementById('myCanvas');
    var ctx = canvas.getContext("2d");

    ctx.beginPath();
    ctx.arc(x, y, r, 0, 2 * Math.PI);
    if (isFilled === true) {
        ctx.fill();
    }
    ctx.closePath();
    ctx.stroke();
}

function drawCurve(cx, cy, ex, ey)
{
    var canvas = document.getElementById('myCanvas');
    var ctx = canvas.getContext("2d");

    ctx.quadraticCurveTo(cx, cy, ex, ey);
    ctx.stroke();
}

function drawLine()
{
    
}

window.onload = function () {
    drawCircle(150, 150, 50, false);
    drawCircle(130, 140, 10, false);
    drawCircle(170, 140, 10, false);
    drawCircle(131, 140, 5, true);
    drawCircle(171, 140, 5, true);
    //drawCurve(390, 390, 450, 450);
    drawCurve(200, 200, 150, 150);
    //drawCurve(100, 200, 300, 400);
}