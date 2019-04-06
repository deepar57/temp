function task1() {
    let obj = getObject();
    console.log(obj);
};

function getObject() {
    let result = {};
    
    let N = +prompt('Введите число от о до 999');
    if (isNaN(N))
    {
        console.log('N is NaN');
        return result;
    }

    if (N < 0 || N > 999)
    {
        console.log('N is out of range [0...999]');
        return result;
    }

    result.сотни = Math.floor(N/100);
    N %= 100;
    
    result.десятки = Math.floor(N/10);
    N %= 10;

    result.единицы = N;

    return result;
};
    
function task2(){
    console.log(QUESTIONS);
    if (game(QUESTIONS))
        alert('Вы миллионер!!!');
};

var generateQuestion = function (mas, qNumber) {
    let answers = '';
    for (let i = 0; i < 4; i++) {
        answers = answers + (i + 1) + ' - ' + mas[qNumber].answers[i] + '\n';
    }

    let text = 'Вопрос №' + (qNumber + 1) + ' на сумму ' + mas[qNumber].cost + 'р.:\n' + mas[qNumber].text + '\n' + answers + 'Введите правильный ответ';

    let right = mas[qNumber].correct;
    return {
        qText: text,
        right: right
    };
};

var check = function (answer, round) {
    if (answer == QUESTIONS[round].correct) {
        alert('Правильно!');
        return true;
    } else {
        alert('НЕПРАВИЛЬНО!');
        return false;
    }
};

var game = function (questions) {
    let play = true;
    let round = 0;
    while (play == true && round < QUESTIONS.length) {
        let quest = generateQuestion(questions, round);
        let answer = prompt(quest.qText);
        play = check(answer, round);
        round++;
    }
    return play;
};

var QUESTIONS = [
    {
        number: 1,
        text: 'Что вставляют в степлер?',
        answers: ['патроны', 'ядра', 'снаряды', 'скобы'],
        correct: 4,
        cost: 500
    },
    {
        number: 2,
        text: 'Что планирует человек, собирающийся «залечь на дно»?',
        answers: ['спрятаться и затаиться', 'пойти на рыбалку', 'заняться дайвингом', 'утопиться'],
        correct: 1,
        cost: 1000
    },
    {
        number: 3,
        text: 'Что такое «карамба»?',
        answers: ['испанское ругательство', 'щупальца каракатицы', 'разбитая иномарка', 'столица Караханидского государства'],
        correct: 1,
        cost: 2000
    },
    {
        number: 4,
        text: 'Откуда все мы вышли, если верить если верить песне «Смело, товарищи, в ногу!»?',
        answers: ['из гоголевской шинели', 'из отряда приматов', 'из вагона', 'из народа'],
        correct: 4,
        cost: 3000
    },
    {
        number: 5,
        text: 'У кого в гостях Винни-Пух попал в безвыходное положение?',
        answers: ['у Пятачка', 'у Кролика', 'у Совы', 'у ослика Иа-Иа'],
        correct: 2,
        cost: 5000
    },
    {
        number: 6,
        text: 'Что означает аббревиатура «имхо», которая часто встречается в интернет-общении?',
        answers: ['вопреки вышеизложенному', 'несмотря на авторитеты', 'уточняя подробности', 'по моему мнению'],
        correct: 4,
        cost: 10000
    },
    {
        number: 7,
        text: 'Как закончить строчку стихотворения Маяковского: «Двое в комнате. Я и…»?',
        answers: ['лень', 'Ленин', 'Лиля', 'Леннон'],
        correct: 2,
        cost: 15000
    },
    {
        number: 8,
        text: 'На чем плавают отдыхающие на море?',
        answers: ['на простыне', 'на одеяле', 'на матрасе', 'на наволочке'],
        correct: 3,
        cost: 25000
    },
    {
        number: 9,
        text: 'На каком курсе школы Хогвартс учился Гарри Поттер, когда раскрыл секрет Тайной комнаты?',
        answers: ['на первом', 'на втором', 'на третьем', 'на четвёртом'],
        correct: 2,
        cost: 50000
    },
    {
        number: 10,
        text: 'Какой обряд перед свадьбой назывался рукобитьем?',
        answers: ['выяснение, кто сильнее', 'праздник друзей жениха', 'одевание невесты', 'скрепление договора'],
        correct: 4,
        cost: 100000
    },
    {
        number: 11,
        text: 'Какой город группа "Кар-Мэн" называла "полным риска"?',
        answers: ['Нью-Йорк', 'Сан-Франциско', 'Лос-Анджелес', 'Детройт'],
        correct: 2,
        cost: 200000
    },
    {
        number: 12,
        text: 'Кто автор строк "Ленин - жил, Ленин - жив, Ленин - будет жить"?',
        answers: ['Есенин', 'Маяковский', 'Сталин', 'Ленин'],
        correct: 2,
        cost: 400000
    },
    {
        number: 13,
        text: 'Чему фанаты Виктора Цоя дали прозвище "Камчатка"?',
        answers: ['котельной', 'рок-клубу', 'коммунальной квартире', 'стене на Арбате'],
        correct: 1,
        cost: 800000
    },    
    {
        number: 14,
        text: 'Какой был цыпленок в популярной шуточной песне?',
        answers: ['вареный', 'тушеный', 'жареный', 'гриль'],
        correct: 3,
        cost: 1500000
    },
    {
        number: 15,
        text: 'Каков правильный ответ на загадку: “Нос стальной, хвост льняной”?',
        answers: ['иголка с ниткой', 'комета Галлея', 'МиГ-25', 'крейсер “Аврора”'],
        correct: 1,
        cost: 3000000
    }
];    
    
