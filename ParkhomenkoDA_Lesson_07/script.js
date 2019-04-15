var canvas = document.querySelector('#canv');
var ctx = canvas.getContext('2d');

var xCoord = document.getElementById('xCoord');
var yCoord = document.getElementById('yCoord');


var getCoordinates = function (evt) {
    let arr = {};
    let x = evt.offsetX;
    let y = evt.offsetY;

    xCoord.innerText = x;
    yCoord.innerText = y;
};

var system = {
    currentTool: '',
    currentColor: document.querySelector('#color'),
    brushSize: 5
};

var renderSystem = function (obj, elem, action) {
    //obj -> change
    obj[elem] = action;
    console.log(system);
};

var switchTool = function (el) {
    if (el.id == 'brush') {
        console.log('brush');
        return 'brush'
    } else if (el.id == 'notbrush') {
        console.log('not brush');
        return 'notbrush'
    }
};

var switchSize = function (list) {
    return list.value
};

var switchColor = function (colorPicker) {
    return colorPicker.value
};


var clicker = function (evt) {
    if (evt.target.classList.contains('toolButton') == true) {
        //console.log (`Выбран инструмент ${evt.target.id}`);
        //switchTool(evt.target);
        console.log(system);
        renderSystem(system, 'currentTool', switchTool(evt.target));
    } else if (evt.target.id == 'sizeSelect') {
        renderSystem(system, 'brushSize', switchSize(evt.target));
    } else if (evt.target.id == 'color') {
        //console.log (`Выбран инструмент color`);
        renderSystem(system, 'currentColor', switchColor(evt.target));
    }
};



var startDraw = function (evt) {
    //зафиксировать нач коорд
    //начать процесс рисования
    if (system.currentTool == 'brush') {
        draw(evt);
    }

};

var endDraw = function (evt) {
    console.log('end');
    canvas.onmousemove = null;
};

var draw = function (evt) {
    canvas.onmousemove = function (evt) {
        ctx.fillStyle = system.currentColor;
        ctx.fillRect(xCoord.innerText, yCoord.innerText, system.brushSize, system.brushSize);
    }
};

canvas.addEventListener('mousemove', getCoordinates);
canvas.addEventListener('mousedown', startDraw);
canvas.addEventListener('mouseup', endDraw);
window.addEventListener('click', clicker);

function updateTime() {   
    let span = document.querySelector('#time');
    if (span != null) {
        //console.log(span);
        span.innerText = (new Date).toString();
        setTimeout(updateTime, 499);
    }
}

updateTime();
//setTimeout(updateTime, 1000);
