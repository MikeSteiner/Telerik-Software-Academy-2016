/**
 * Created by Admin on 23.6.2016 г..
 */
/*
 Digit as word

 Description

 Write a script that asks for a digit  (0-9) , and depending on the input, shows the digit as a word (in English). Print  not a digit  in case of invalid input. Use a  switch  statement.

 Input
 •The input will consist of an array containing a single string

 Output
 •The output should be a single line

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 2 two
 1 one
 0 zero
 5 five
 -0.1 not a digit
 hi not a digit
 9 nine
 10 not a digit


 */


// var input = [2.5, 3, 5, 5, 3, 4];
// solve(input);

function solve(args) {

    // var argsLen = args.length;
    // for(var i = 0; i < argsLen; i = i + 1){
    //     var n = args[i]
    // }

    var N = args[0];

    digitAsWord(N);

    function digitAsWord(digit) {
        var result;
        switch (Number(digit)) {
            case 1:
                result = 'one';
                break;
            case 2:
                result = 'two';
                break;
            case 3:
                result = 'three';
                break;
            case 4:
                result = 'four';
                break;
            case 5:
                result = 'five';
                break;
            case 6:
                result = 'six';
                break;
            case 7:
                result = 'seven';
                break;
            case 8:
                result = 'eight';
                break;
            case 9:
                result = 'nine';
                break;
            default:
                result = "not a digit";
                break;
        }

        console.log(result);
    }
}



