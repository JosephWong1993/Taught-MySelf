var numbers = [1, 2, 3, 4, 5, 4, 3, 2, 1];

var mapResult = numbers.map(function (item, index, array) {
    return item * 2;
});

console.log(mapResult.toString()); //  [2,4,6,8,10,8,6,4,2]