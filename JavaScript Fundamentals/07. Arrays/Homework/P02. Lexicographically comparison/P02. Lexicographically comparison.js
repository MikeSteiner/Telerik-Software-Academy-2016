/**
 * Created by Admin on 29.6.2016 г..
 */


function solve(params) {
    var arr = params[0].split('\n');
    var istrue = false;

    if (arr[0] === arr[1]) {
        console.log('=');
        istrue = true;
    } else {
        for (var i = 0; i < Math.min(arr[0].length, arr[1].length); i++) {
            if (arr[0][i] > arr[1][i]) {
                console.log('>');
                istrue = true;
                break;
            } else if (arr[0][i] < arr[1][i]) {
                console.log('<');
                istrue = true;
                break;
            }

        }
    }
    if (istrue === false) {
        if (arr[0].length > arr[1].length) {
            console.log('>');
        } else {
            console.log('<');
        }
    }
}