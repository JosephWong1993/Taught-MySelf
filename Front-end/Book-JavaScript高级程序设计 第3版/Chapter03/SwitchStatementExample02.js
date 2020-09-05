var i = 25;

switch (i) {
    case 25:
    /* 合并两种情形 */
    case 35:
        console.log("25 or 35");
        break;
    case 45:
        console.log("45");
        break;
    default:
        console.log("Other");
}