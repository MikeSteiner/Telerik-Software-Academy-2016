/**
 * Created by Admin on 29.6.2016 г..
 */

function solve(params) {
    var n = +params[0];
    var isPrime = false;
    for (var i = n; i > 1; i-=1) {
        isPrime = true;
        for (var j = (Math.sqrt(i)|0); j > 1; j-=1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            return i;
        }
    }
}
