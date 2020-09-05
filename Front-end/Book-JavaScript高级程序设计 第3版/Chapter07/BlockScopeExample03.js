function ouputNumbers(count) {
    (function () {
        for (var i = 0; i < count; i++) {
            console.log(i);
        }
    })();

    console.log(i); //导致一个错误!
}

ouputNumbers(5);