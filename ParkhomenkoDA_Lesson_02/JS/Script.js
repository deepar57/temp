let a, b;

// 3
/*
a = +prompt('Введите a');
b = +prompt('Введите b');

if (a >= 0 && b >= 0)
    console.log('разность=' + (a - b));
else if (a < 0 && b < 0)
    console.log('произведение=' + (a * b));
else
    console.log('сумма=' + (a + b));
*/

// 4
a = Math.round(Math.random() * 15);

switch (a) {
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
    case 11:
    case 12:
    case 13:
    case 14:
    case 15:
        var str = '';
        for (var i = a; i <= 15; i++) {
            if (str.length > 0) str += ', ';
            str += i;
        }
        console.log('switch: ' + str);
        break;
}

// 5
a = 3, b = 5;
console.log('+: ' + math1(a, b));
console.log('-: ' + math2(a, b));
console.log('*: ' + math3(a, b));
console.log('/: ' + math4(a, b));

function math1(a, b) {
    return a + b;
};

function math2(a, b) {
    return a - b;
};

function math3(a, b) {
    return a * b;
};

function math4(a, b) {
    return a / b;
};

// 6
console.log('+: ' + mathOperation(a, b, '+'));
console.log('-: ' + mathOperation(a, b, '-'));
console.log('*: ' + mathOperation(a, b, '*'));
console.log('/: ' + mathOperation(a, b, '/'));

function mathOperation(arg1, arg2, operation) {
    switch (operation) {
        case '+':
            return arg1 + arg2;
        case '-':
            return arg1 - arg2;
        case '*':
            return arg1 * arg2;
        case '/':
            return arg1 / arg2;
    }
}
