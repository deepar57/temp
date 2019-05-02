const goods = [
    {
        title: "Shirt",
        price: 150,
        img: "phone1.jpg"
    },
    {
        title: "Socks",
        price: 50,
        img: "phone2.jpg"
    },
    {
        title: "Jacket",
        price: 350,
        img: "phone3.jpg"
    },
    {
        title: "Shoes",
        price: 250,
        img: "phone1.jpg"
    }
]

const renderGoodsItem = (title = 'Безымянный', price = 'Бесценный', img = '#') => {
    return `<div class="goods-item">
    <img class="goods-item-img" src="img/${img}" alt="{title}">
    <h3>${title}</h3>
    <p>${price}</p>
    <button class="btn">Добавить</button>
  </div>`;
}

const renderClr = () => `<div class="clr"></div>`;

const renderGoodsList = (list) => {
    const goodsList = list.map(item => renderGoodsItem(item.title, item.price, item.img));
    goodsList.push(renderClr());
    document.querySelector('.goods-list').innerHTML = goodsList.join('');
}

renderGoodsList(goods)
