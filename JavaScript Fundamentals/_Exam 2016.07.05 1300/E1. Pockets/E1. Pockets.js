/**
 * Created by Admin on 5.7.2016 г..
 */
/*
 Description

 The earth is not flat. You are given a sequence of numbers representing heights. A peak is a height, that is larger than its direct neighbours and has exactly two of them. A valley is a sequence of 3 or more heights between two peaks, including the peaks.

 A pocket is a valley that:

 Has immediate neighbours (N1 and N2)) which are peaks


 Pockets are in green
 Your task is to write a program which finds the sum of all pockets in a valley.

 Input

 Input will consist of an array with single element: the heights with a space between them
 The input will always be valid and in the described format. There is no need to validate it explicitly.
 Output

 Output should consist of a single line: the sum of all pockets
 Constraints

 The number of heights will always be less than 10000
 Each height will be between 0 and 50
 Time limit: 0.3 s
 Memory limit: 16 MB
 Solution template

 Follow the exact template:
 function solve(args){
 let heights = args[0]...

 let result;

 //your solution here

 console.log(result);
 }
 Sample tests

 Sample Test 1

 Input

 [
 "53 20 1 30 2 40 3 10 1"
 ]
 Output

 5
 Sample Test 2

 Input

 [
 "53 20 1 30 30 2 40 3 10 1"
 ]
 Output

 3
 Sample Test 3

 Input

 [
 "53 20 1 30 2 40 3 3 10 1"
 ]
 Output

 2
 */


// A peak is a height, that is larger than its direct neighbours and has exactly two of them.
// A valley is a sequence of 3 or more heights between two peaks, including the peaks.
//
// A pocket is a valley that:
// Has immediate neighbours (N1 and N2)) which are peaks
//
// Your task is to write a program which finds the sum of all pockets in a valley.

function solve(args){
    var numbers = new Array();
    var pockets = new Array();

    Array.prototype.sum = function () {
        var s = 0;
        for(var i = 0; i < this.length; i += 1){
            s += this[i];
        }

        return s;
    }

    // console.log(args);

    numbers = ("" + args[0]).split(" ").map(Number);

    var pivotElement = 0;


    // TODO Main loop going trough all numbers from 1 to numbers.len - 1
    for(var mainIx = 2; mainIx < numbers.length - 2; mainIx += 1){

        var leftPeakValue = 0;
        var leftPeakIx = -1;
        var rightPeakValue = 0;
        var rightPeakIx = -1;

        var pivotElement = numbers[mainIx];

        // TODO Secondary loop searching for two consequtive peaks and a valley between them
        while (true){

            // Left peak variables
            var leftPeakPrevIx = mainIx - 2;
            var leftPeakIx = mainIx - 1;
            var leftPaekNextIx = mainIx;
            var leftPeakValue = numbers[leftPeakIx];

            // Right peak variables
            var rightPeakPrevIx = mainIx;
            var rightPeakIx = mainIx + 1;
            var rightPeakNexIx = mainIx + 2;
            var rightPeakValue = numbers[rightPeakIx];

            var isPeakPrevElement = ((leftPeakValue > numbers[leftPeakPrevIx]) && (leftPeakValue > numbers[leftPaekNextIx]));
            var isPeakNextElement = ((rightPeakValue > numbers[rightPeakPrevIx]) && (rightPeakValue > numbers[rightPeakNexIx]));

            // Check if the pivot element is a pocket
            if(isPeakPrevElement && isPeakNextElement){
                pockets.push(pivotElement);
                mainIx += 1;

                break;
            } else {

                break;
            }
        }

        // console.log(pockets);

    }

    console.log(pockets.sum());
}



// var input = [ '53 20 1 30 2 40 3 10 1' ];
// var input = [ '53 20 1 30 30 2 40 3 10 1' ];
var input = [ '53 20 1 30 2 40 3 3 10 1' ];
solve(input);