/**
 * Created by Admin on 23.6.2016 г..
 */
/**
 * Created by Admin on 23.6.2016 г..
 */
/*
 The biggest of Three

 Description

 Write a script that finds the biggest of three numbers. Use nested  if  statements.

 Input
 •The input will consist of an array containing three values represented as strings

 Output
 •The output should be a single line containing a number

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output
 5
 2
 2 5
 -2
 -2
 1 1
 -2
 4
 3 4
 0
 -2.5
 5 5
 -0.1
 -0.5
 -1.1 -0.1
 */

// var input = [5, 2, 2, -2, -2, 1, -2, 4, 3, 0 -2.5, 5, -0.1, -0.5, -1.1];
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

    largestOfThreeNumbers(a, b, c);

    function largestOfThreeNumbers(a, b, c) {

        a = parseFloat(a);
        b = parseFloat(b);
        c = parseFloat(c);

        if (a > b) {
            if (a > c) {
                console.log(a);
            } else {
                console.log(c);
            }
        } else {
            if (b > c) {
                console.log(b);
            } else {
                console.log(c);
            }
        }
    }
}



