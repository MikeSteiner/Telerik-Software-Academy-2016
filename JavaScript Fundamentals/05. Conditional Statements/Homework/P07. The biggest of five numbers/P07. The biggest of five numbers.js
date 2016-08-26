/**
 * Created by Admin on 23.6.2016 г..
 */
/**
 * Created by Admin on 23.6.2016 г..
 */
/*
 The biggest of five numbers

 Description

 Write a script that finds the biggest of given 5 variables. Use nested  if  statements.

 Input
 •The input will consist of an array containing five values represented as strings

 Output
 •The output should be a single line containing the answer

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 5
 2
 2
 4
 1 5
 -2
 -22
 1
 0
 0 1
 -2
 4
 3
 2
 0 4
 0
 -2.5
 0
 5
 5 5
 -3
 -0.5
 -1.1
 -2
 -0.1 -0.1
 */

// var input = [2.5, 3, 5, 5, 3, 4];
// solve(input);

function solve(args) {

    // var argsLen = args.length;
    // for(var i = 0; i < argsLen; i = i + 2){
    //     var w = args[i];
    //     var h = args[i + 1];
    // }

    var a = args[0];
    var b = args[1];
    var c = args[2];
    var d = args[3];
    var e = args[4];

    largestOfFiveNumbers(a, b, c, d, e);

    function largestOfFiveNumbers(a, b, c, d, e) {
        var result;
        // var arrayA = []
        // var arrayB = new Array()
        var nums = new Array(5);

        a = parseFloat(a);
        b = parseFloat(b);
        c = parseFloat(c);
        d = parseFloat(d);
        e = parseFloat(e);


        nums[0] = a;
        nums[1] = b;
        nums[2] = c;
        nums[3] = d;
        nums[4] = e;

        result = Math.max.apply(Math, nums);

        console.log(result);
    }
}



