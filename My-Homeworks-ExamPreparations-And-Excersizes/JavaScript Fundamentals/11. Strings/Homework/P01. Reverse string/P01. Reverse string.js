/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 Reverse string

 Description

 Write a JavaScript function that reverses a string.

 Input
 •The input will consist of an array containing one string

 Output
 •The output should be consisted of one line - the reversed string

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Sample Test 1

 Input

 [ 'sample' ]

 Output
 elpmas


 Sample Test 2

 Input

 [ 'qwertytrewq' ]

 Output
 qwertytrewq

 */

function solve(args) {
    var originalString = args[0];
    var reversedString = "";

    for(var i = originalString.length - 1; i >= 0; i-=1){
        reversedString = reversedString + originalString[i];
    }

    console.log(reversedString);
}

// var input = [ 'sample' ];
var input = [ 'qwertytrewq' ];
solve(input);