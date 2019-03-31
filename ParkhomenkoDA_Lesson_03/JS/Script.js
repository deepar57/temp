let i;

// 1
let IsPrimeNumber = function (N) {
    let result = true;
    switch (N) {
        case 0:
        case 1:
            result = false;
            break;

        case 2:
        case 3:
            result = true;
            break;

        default:
            for (let i = 2; i < N; i++)
                if ((N % i) == 0) {
                    // Не простое число
                    result = false;
                    break;
                }
    }
    return result;
}

i = 0;
let primeNumbers = [];
while (i <= 100) {
    if (IsPrimeNumber(i))
        primeNumbers.push(i);
    i++;
}
console.log('Простые числа: ' + primeNumbers.join());

// 2, 3
let products = ['молоко', 'сахар', 'чай'];
let price = [88, 75, 46];

let countBasketPrice = function (products, price) {
    let i = 0;
    let cost = 0;
    while (i < products.length) {
        // Вроде ищем цену в другом массиве
        if (i < price.length)
            cost += price[i];
        i++;
    }
    return cost;
}

console.log('Стоиомсть товаров в корзине: ' + countBasketPrice(products, price));

// 4
let arr = [];
for (i = 0; i <= 9; arr.push(i++));
console.log('0-9: ' + arr.join());

// 5
let str;
for (let r = 0; r < 20; r++) {
    str = '';
    for (i = 0; i < r + 1; i++)
        str += 'x';
    console.log(str);
}
