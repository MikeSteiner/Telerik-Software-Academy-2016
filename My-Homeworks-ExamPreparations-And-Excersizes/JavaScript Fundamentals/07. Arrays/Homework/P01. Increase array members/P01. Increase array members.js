/**
 * Created by Admin on 29.6.2016 г..
 */

function solve(params) {
    var num = +params[0];
    var arr = [];
    arr[num-1] = undefined;

    for (var i = 0; i < num; i+=1) {
        arr[i] = i * 5;
        console.log(arr[i]);
    }
}
