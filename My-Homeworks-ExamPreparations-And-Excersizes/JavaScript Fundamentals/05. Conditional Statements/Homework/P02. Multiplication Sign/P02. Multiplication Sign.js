/**
 * Created by Admin on 23.6.2016 г..
 */
/*
 Multiplication Sign

 Description

 Write a script that shows the sign ( + ,  -  or  0 ) of the product of three real numbers, without calculating it.
 Use a sequence of  if  operators.

 Input
 •The input will consist of an array containing three values -  a ,  b  and  c  represented as strings

 Output
 •The output should be a single line containing  + ,  -  or  0

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 5
 2
 2 +
 -2
 -2
 1 +
 -2
 4
 3 -
 0
 -2.5
 4 0
 -1
 -0.5
 -5.1 -
 */


var input = [5, 2, 2, -2, -2, 1, -2, 4, 3, 0, -2.5, 4, -1, -0.5, -5.1];
solve(input);

function solve(args) {

    var argsLen = args.length;
    for(var i = 2; i < argsLen; i = i + 3){
        var a = args[i - 2];
        var b = args[i - 1];
        var c = args[i];

        multiplicationSign(a, b, c);
    }

    // var a = args[0];
    // var b = args[1];
    // var c = args[2];

    multiplicationSign(a, b, c);

    function multiplicationSign(a, b, c) {
        a = parseFloat(a);
        b = parseFloat(b);
        c = parseFloat(c);

        // var res = a * b * c;
        // res = parseInt(res);
        //
        // if(res > 0){
        //     console.log("+");
        // }
        // else if(res < 0){
        //     console.log("-");
        // }
        // else {
        //     console.log("0");
        // }

        if(a===0 || b===0 || c===0) {
            console.log("0");
            return;
        }

        if((a > 0 && b > 0 && c > 0) ||
            (a < 0 && b < 0 && c > 0) ||
            (a < 0 && b > 0 && c < 0) ||
            (a > 0 && b < 0 && c < 0)) {
            console.log("+");
        }
        else {
            console.log("-");
        }

    }
}



