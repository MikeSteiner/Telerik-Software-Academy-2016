/**
 * Created by Admin on 29.6.2016 г..
 */
/**
 * Larger than neighbours

 Description

 Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

 Input
 •On the first line you will receive the number N - the size of the array
 •On the second line you will receive N numbers separated by spaces - the array

 Output
 •Print how many numbers in the array are larger than their neighbours

 Constraints
 •1 <= N <= 1024
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 6
 -26 -25 -28 31 2 27
 2

 * @param args
 */

// [ '6', '-26 -25 -28 31 2 27' ]
// var input = [ '6', '-26 -25 -28 31 2 27' ];
// solve(input);

function solve(args) {

    var N = parseInt(args[0]);
    var inputArr = ("" + args[1]);
    inputArr = inputArr.split(/\s+/g);
    inputArr = inputArr.map(function (item) {
        return parseInt(item, 10);
    });
    //console.log(inputArr);

    console.log(largerThanNeighbour(inputArr));

    function largerThanNeighbour(numbers) {
        var largerCounter = 0;

        for(i = 0; i < numbers.length; i = i + 1){

            var isLargerThanNeighburs = false;
            if(i == 0 && i !== numbers.length - 1){
                // isLargerThanNeighburs = (numbers[i] > numbers[i + 1]);
            }else if(i == numbers.length - 1 && i !== 0){
                // isLargerThanNeighburs = (numbers[i] > numbers[i - 1]);
            }
            else{
                isLargerThanNeighburs = (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]);
            }

            if (isLargerThanNeighburs){
                largerCounter = largerCounter + 1;
            }
        }

        return largerCounter;
    }
}


//
// function solve(params) {
//     var arr = ((params+'').split('\n'))[1].split(' ');
//     var count = 0;
//
//     for(var i = 0; i < arr.length; i+=1){
//         if (+arr[i] > +arr[i-1] && +arr[i] > +arr[i+1]) {
//             count++;
//         }
//     }
//     console.log(count);
// }