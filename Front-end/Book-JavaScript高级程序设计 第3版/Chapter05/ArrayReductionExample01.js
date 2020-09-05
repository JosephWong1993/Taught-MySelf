var values = [1, 2, 3, 4, 5];
//  reduce,reduceRight
var sum = values.reduceRight(function (prev, cur, index, array) {
    return prev + cur;
});
console.log(sum);   //  15
console.log(values.toString());