/**
 * Created by Admin on 23.6.2016 г..
 */
/*
 Sort 3 numbers

 Description

 Sort 3 real values in descending order. Use nested  if  statements.

 Note: Don’t use arrays and the built-in sorting functionality.

 Input
 •The input will consist of an array containing three values represented as strings

 Output
 •The output should be a single line containing three numbers separated by spaces

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 5
 1
 2 5 2 1
 -2
 -2
 1 1 -2 -2
 -2
 4
 3 4 3 -2
 0
 -2.5
 5 5 0 -2.5
 -1.1
 -0.5
 -0.1 -0.1 -0.5 -1.1
 10
 20
 30 30 20 10
 1
 1
 1 1 1 1
 */

// var input = [2.5, 3, 5, 5, 3, 4];
// solve(input);

function solve(args) {

    // var argsLen = args.length;
    // for(var i = 2; i < argsLen; i = i + 3){
    //     var a = args[i - 2];
    //     var b = args[i - 1];
    //     var c = args[i];
    //
    //     largestOfThreeNumbers(a, b, c);
    // }

    var a = args[0];
    var b = args[1];
    var c = args[2];

    sortThreeNumbers(a, b, c);

    function sortThreeNumbers(a, b, c) {
        a = parseFloat(a);
        b = parseFloat(b);
        c = parseFloat(c);

        var result, temp;

        if (a <= b) {
            if (b <= c) {
                temp = a;
                a = c;
                c = temp;
            } else if (a <= c){
                temp = a;
                a = b;
                b = c;
                c = temp;
            } else {
                temp = a;
                a = b;
                b = temp;
            }
        } else {
            if (b < c){
                temp = b;
                b = c;
                c = temp;
            }
        }
        result = (a + " " + b + " " + c);
        console.log(result);
    }
}



