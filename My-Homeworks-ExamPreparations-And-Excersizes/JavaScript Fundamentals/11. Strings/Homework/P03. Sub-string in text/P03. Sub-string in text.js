/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 Sub-string in text

 Description

 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

 Input
 •The input will consist of an array containing one string

 Output
 •The output should be consisted of one line - the number of marches

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Input

 [
 'in',
 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
 ]

 Output
 9
 Explanation

 We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

 */

function solve(args) {
    //console.log(args);

    var searchedWord = "" + args[0];
    var text = "" + args[1];

    var searchedWordCounter = 0;

    //var pattern = /in/gi;
    var pattern = new RegExp(searchedWord, "gi")
    searchedWordCounter = text.match(pattern).length;

    console.log(searchedWordCounter);
}

var input = [ 'in','We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.' ];
solve(input);