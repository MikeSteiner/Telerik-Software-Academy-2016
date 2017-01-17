/**
 * Created by Admin on 23.6.2016 г..
 */
/*
 Quadratic equation

 Description

 Write a script that reads the coefficients  a ,  b  and  c  of a quadratic equation  ax2 + bx + c = 0
 and solves it (prints its real roots). Calculates and prints its real roots.

 Note: Quadratic equations may have 0, 1 or 2 real roots.

 Input
 •The input will consist of an array containing three values -  a ,  b  and  c  represented as strings

 Output
 •The output should be a single line containing the real roots (see sample tests) ◦
 Print numbers with two digits of precision after the floating point
 If there are two roots then  x1 < x2


 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests
 Input
 Output
 2
 5
 -3 x1=-3.00; x2=0.50
 -1
 3
 0 x1=0.00; x2=3.00
 -0.5
 4
 -8 x1=x2=4.00
 5
 2
 8 no real roots
 0.2
 9.572
 0.2 x1=-47.84; x2=-0.02
 */

// var input = [2, 5, -3, -1, 3, 0, -0.5, 4, -8, 5, 2, 8, 0.2, 9.572, 0.2];
// solve(input);

function solve(args) {
    // var argsLen = args.length;
    // for(var i = 2; i < argsLen; i = i + 3){
    //     var a = args[i - 2];
    //     var b = args[i - 1];
    //     var c = args[i];
    //
    //     quadraticEquation(a, b, c);
    // }

    var a = args[0];
    var b = args[1];
    var c = args[2];

    quadraticEquation(a, b, c);

    function quadraticEquation(a, b, c) {
        a = parseFloat(a);
        b = parseFloat(b);
        c = parseFloat(c);
        var D = 0.0
        var x1 = 0.0;
        var x2 = 0.0;

        D = (b * b) - (4 * a * c);

        if(D === 0) {
            x1 = -b / (2 * a);
            console.log("x1=x2=" + x1.toFixed(2));
        }
        else if(D > 0) {
            x1 = (-b - Math.sqrt(D)) / (2 * a);
            x2 = (-b + Math.sqrt(D)) / (2 * a);
            console.log("x1=" + x1.toFixed(2) + "; x2=" + x2.toFixed(2));
        }
        else {
            console.log("no real roots");
        }
    }

}



