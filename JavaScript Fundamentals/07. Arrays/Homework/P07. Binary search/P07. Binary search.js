/**
 * Created by Admin on 29.6.2016 г..
 */


function solve(params) {
    var arr = params[0].split('\n');
    var elementToSearch = arr[arr.length-1];
    arr.pop();
    for(var i = 1; i < arr.length; i+=1) {
        if (arr[i] == elementToSearch) {
            return i-1;
        }
    }
    return -1;
}