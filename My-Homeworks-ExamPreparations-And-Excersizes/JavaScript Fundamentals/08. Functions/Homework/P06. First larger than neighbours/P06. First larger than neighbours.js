/**
 * Created by Admin on 29.6.2016 г..
 */
/**
 * First larger than neighbours

 Description

 Write a method that returns the index of the first element in array that is larger than its neighbours, or  -1 , if there is no such element.

 Input
 •On the first line you will receive the number N - the size of the array
 •On the second line you will receive N numbers separated by spaces - the array

 Output
 •Print the index of the first element that is larger than its neighbours or  -1  if none are

 Constraints
 •1 <= N <= 1024
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 6
 -26 -25 -28 31 2 27 1

 Submission
 * @param params
 * @returns {*}
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

    console.log(indexOfLargerThanNeighbour(inputArr));

    function indexOfLargerThanNeighbour(numbers) {
        var ixOfFirstLargerThanNeighbours = -1;

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
                ixOfFirstLargerThanNeighbours = i;
                break;
            }
        }

        return ixOfFirstLargerThanNeighbours;
    }
}

// function solve(params) {
//     var arr = ((params+'').split('\n'))[1].split(' ');
//
//     for(var i = 0; i < arr.length; i+=1){
//         if (+arr[i] > +arr[i-1] && +arr[i] > +arr[i+1]) {
//             return i;
//         }
//     }
//     return -1;
// }