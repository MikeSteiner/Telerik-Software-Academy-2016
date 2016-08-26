/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 nbsp

 Description

 Write a function that replaces non breaking white-spaces in a text with  &nbsp .

 Input
 •The input will consist of an array containing one string

 Output
 •The output should be consisted of one line

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Sample Test 1

 Input

 [ 'hello world' ]

 Output
 hello&nbsp;world


 Sample Test 2

 Input

 [ 'This text contains 4 spaces!!' ]

 Output
 This&nbsp;text&nbsp;contains&nbsp;4&nbsp;spaces!!


 */

function solve(args) {
    //console.log(args);

    var text = "" + args[0];
     var replacedSpaces = text.replace(/ /g, "&nbsp;");

    console.log(replacedSpaces);
}

// var input = [ 'hello world' ];
var input =  [ 'This text contains 4 spaces!!' ];

solve(input);