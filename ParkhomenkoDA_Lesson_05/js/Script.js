function task2() {
    let b = document.querySelector('#b');
    if (b != null) {
        let h3 = document.createElement('h3');
        h3.textContent = b.textContent;
        b.parentNode.insertBefore(h3, b);
        b.parentNode.removeChild(b);
    }
};

function task3() {
    let nodes = document.getElementsByTagName('li');
    for (let i = 0; i < nodes.length; i++)
        nodes[i].textContent = i + 1;
}

function task4(op) {
    let result = mathOperation(parseInt(document.querySelector('#val1').value), parseInt(document.querySelector('#val2').value), op);
    document.querySelector('#result').textContent = result;
}

function mathOperation(arg1, arg2, op) {
    switch (op) {
        default:
            return NaN;
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

function task5() {
    let li = document.querySelector('#list');
    if (li != null) {
        let liNew = document.createElement('li');
        liNew.textContent = 'Первый элемент списка';
        li.parentNode.insertBefore(liNew, li);
    }
};

function task6() {
    let board = genChessBoard();

    let divBoard = document.querySelector('#chessBoard');
    if (divBoard.querySelector('.cell') == null) {
        let divLine, divCell;

        for (let n = 7; n >= 0; n--) {
            divLine = document.createElement('div');
            divLine.classList.add('line');
            
            for (let l = 0; l < 8; l++) {
                divCell = document.createElement('div');
                divCell.id = board[l][n].name;
                divCell.classList.add('cell');
                divCell.classList.add(board[l][n].isBlack ? 'black' : 'white');
                divLine.appendChild(divCell);
            }
            
            divCell = document.createElement('div');
            divCell.style.clear = 'both';
            divLine.appendChild(divCell);            
            
            divBoard.appendChild(divLine);
        }

        divBoard.classList.add('board');
    }
}

function genChessBoard() {
    let board = [];
    let ls = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'];
    let line;

    for (let l = 0; l < 8; l++) {
        line = [];
        for (let n = 0; n < 8; n++) {
            line.push({
                name: ls[l] + (n + 1),
                isBlack: (l % 2 == 0 && n % 2 == 0) || (l % 2 != 0 && n % 2 != 0)
            });
        }
        board.push(line);
    }

    return board;
}
