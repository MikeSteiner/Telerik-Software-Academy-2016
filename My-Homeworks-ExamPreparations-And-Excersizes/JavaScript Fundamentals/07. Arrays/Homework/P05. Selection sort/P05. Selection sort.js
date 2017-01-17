/**
 * Created by Admin on 29.6.2016 г..
 */

function solve(args) {
    var array = args[0].split('\n');
    var params = array.slice(1, +array[0]+1);
    var p = 0;
    var i = 0;
    var corrected = false;
    do {
        corrected = false;
        for ( i = 1; i < params.length ; i++) {
            if (+params[i] < +params[i-1]) {
                p = +params[i];
                params[i] = +params[i-1];
                params[i-1] = p;
                corrected = true;
            }
        }
    } while (corrected);

    console.log(params.join('\n'));
}