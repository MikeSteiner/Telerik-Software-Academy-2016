/*
 Trapezoids

 Description

 Implement a javascript function that calculates trapezoid's area by given sides a and b and height h.
 The three values should be read from the console in the order shown below.
 All three value will be floating-point numbers.

 Input
 •The input will consist of an array with exactly 3 numbers as elements: a, b and h, all as strings.

 Output
 •Output a single line containing a single value - the area of the trapezoid. Output the area with exactly 7-digit precision after the floating point.
 •You can use  console.log  to print the results or you can use  return  to return the answer. Both are correct.

 Constraints
 •All numbers will always be valid floating-point numbers in the range  [-500, 500] .
 •Time limit: 0.1s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 5
 7
 12 72.0000000
 2
 1
 33 49.5000000
 8.5
 4.3
 2.7 17.2800000
 100
 200
 300 45000.0000000
 0.222
 0.333
 0.555 0.1540125

 Submission
 */

// var input = [5, 7, 12, 2, 1, 33, 8.5, 4.3, 2.7, 100, 200, 300, 0.222, 0.333, 0.555];
// solve(input);

function solve(args) {

    // var argsLen = args.length;
    // for(var i = 2; i < argsLen; i = i + 3){
    //     var a = args[i - 2];
    //     var b = args[i - 1];
    //     var h = args[i];
    //
    //     var trapArea = TrapezoidsArea(a, b, h);
    //
    //     console.log(trapArea.toFixed(7));
    // }

    var a = args[0];
    var b = args[1];
    var h = args[2];

    var trapArea = TrapezoidsArea(a, b, h);

    console.log(trapArea.toFixed(7));

    function TrapezoidsArea(a, b, h) {
        a = parseFloat(a);
        b = parseFloat(b);
        h = parseFloat(h);

        var area = (a + b) * h / 2;

        return area;
    }
}