/*
 Exchange if greater

 Description

 Write an  if  statement that takes two double variables  a  and  b  and exchanges their values if the first one is greater than the second. As a result print the values  a  and  b , separated by a space.

 Input
 •The input will consist of an array containing two values -  a  and  b  represented as strings

 Output
 •The output should be a single line containing two numbers

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Input

 Output

 5
 2 2 5
 3
 4 3 4
 5.5
 4.5 4.5 5.5

 */


// var input = [5, 2, 3, 4, 5.5, 4.5];
// solve(input);

function solve(args) {

    // var argsLen = args.length;
    // for(var i = 1; i < argsLen; i = i + 2){
    //     var a = args[i - 1];
    //     var b = args[i];
    //
    //     exchangeIfGreater(a, b)
    // }

    var a = args[0];
    var b = args[1];

    exchangeIfGreater(a, b)

    function exchangeIfGreater(a, b) {
        a = parseFloat(a);
        b = parseFloat(b);
        diffComparer = 0.000000001;

        var isGreaterA = (a - b > diffComparer);
        if (isGreaterA) {
            var temp = a;
            a = b;
            b = temp;
        }

        console.log(a + " " + b);
    }
}



