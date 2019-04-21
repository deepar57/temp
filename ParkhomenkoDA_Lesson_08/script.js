var canvas = document.querySelector('#canv');
var ctx = canvas.getContext('2d');

var xCoord = document.getElementById('xCoord');
var yCoord = document.getElementById('yCoord');
var inputTool = document.getElementById('toolSelect');
var inputSize = document.getElementById('sizeSelect');
var inputColor = document.getElementById('color');

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
    return el.value;
};

var switchSize = function (list) {
    return parseInt(list.value);
};

var switchColor = function (colorPicker) {
    return colorPicker.value;
};

var onToolChanged = function (evt) {
    renderSystem(system, 'currentTool', switchTool(evt.target));
}

var onSizeChanged = function (evt) {
    renderSystem(system, 'brushSize', switchSize(evt.target));
}

var onColorChanged = function (evt) {
    renderSystem(system, 'currentColor', switchColor(evt.target));
}

var startDraw = function (evt) {
    if (system.currentTool != null)
        draw(evt);
};

var endDraw = function (evt) {
    console.log('end');
    canvas.onmousemove = null;
};

var draw = function (evt) {
    canvas.onmousemove = function (evt) {
        switch (system.currentTool)
        {
            case 'Circle':
                ctx.fillStyle = system.currentColor;
                ctx.beginPath();
                ctx.arc(xCoord.innerText, yCoord.innerText, system.brushSize / 2, 0, Math.PI * 2);                
                ctx.fill();
                break;

            case 'Rect': 
                ctx.fillStyle = system.currentColor;
                ctx.fillRect(xCoord.innerText, yCoord.innerText, system.brushSize, system.brushSize);
                break;

            case 'No':
            default:
                break;
        }
    }
};

canvas.addEventListener('mousemove', getCoordinates);
canvas.addEventListener('mousedown', startDraw);
canvas.addEventListener('mouseup', endDraw);
inputTool.addEventListener('change', onToolChanged);
inputSize.addEventListener('change', onSizeChanged);
inputColor.addEventListener('change', onColorChanged);

function updateTime() {   
    let span = document.querySelector('#time');
    if (span != null) {
        span.innerText = (new Date).toString();
        setTimeout(updateTime, 499);
    }
}

updateTime();