/**
 * Created by Admin on 29.6.2016 г..
 */
/**
 * Sorting array

 Description

 Write a method that returns the maximal element in a portion of array of integers starting at given index.
 Using it write another method that sorts an array in ascending / descending order.
 Write a program that sorts a given array.

 Input
 •On the first line you will receive the number N - the size of the array
 •On the second line you will receive N numbers separated by spaces - the array

 Output
 •Print the sorted array ◦Elements must be separated by spaces


 Constraints
 •1 <= N <= 1024
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 6
 3 4 1 5 2 6
 1 2 3 4 5 6

 10
 36 10 1 34 28 38 31 27 30 20
 1 10 20 27 28 30 31 34 36 38

 Submission
 * @param params
 */

// [ '6', '3 4 1 5 2 6' ]
// [ '10', '36 10 1 34 28 38 31 27 30 20' ]
// var input = [ '10', '36 10 1 34 28 38 31 27 30 20' ];
// solve(input);

function solve(args){
    const MAX_INTEGER_ATO = 9007199254740991;

    var N = args[0];
    var inputArr = new Array();
    inputArr = ("" + args[1])
        .split(" ")
        .map(function (s) {
            return parseInt(s);
        });
    //console.log(inputArr);

    var arrSorted = mySelectionSort(inputArr);
    console.log(arrSorted.join(" "));



    function mySelectionSort(arrToSort) {
        // repeat (numOfElements - 1) times
        // set the first unsorted element as the minimum
        // for each of the unsorted elements
        // if element < currentMinimum
        //     set element as new minimum
        // swap minimum with first unsorted position

        for(var pivotIx = 0; pivotIx < arrToSort.length - 1; pivotIx++){
            var pivotEl = arrToSort[pivotIx];

            //Find the min from the unsorted elements
            var currMinEl =  MAX_INTEGER_ATO;
            var currMinIx =  -1;
            for(var i = pivotIx + 1; i < arrToSort.length; i = i + 1){
                var currEl = arrToSort[i];
                var isNewMin = (currEl < currMinEl);
                if(isNewMin){
                    currMinEl = currEl;
                    currMinIx = i;
                }
            }

            // Compare the best min with the pivot and swap if is a better min
            var isToBeSwapped = (currMinEl < pivotEl);
            if (isToBeSwapped){
                var holderPivotEl = pivotEl;
                arrToSort[pivotIx] = arrToSort[currMinIx];
                arrToSort[currMinIx] = holderPivotEl;
            }
        }

        return arrToSort;
    }

}


// repeat (numOfElements - 1) times
// set the first unsorted element as the minimum
// for each of the unsorted elements
// if element < currentMinimum
//     set element as new minimum
// swap minimum with first unsorted position


// function solve(params) {
//     var arr = (params + '').split('\n')[1].split(' ');
//     var found = false;
//     var aOff = 0;
//     var holder;
//     do {
//         found = false;
//         for (var i = 1; i < arr.length - aOff; i++) {
//             if (+arr[i] > +arr[i-1]) {
//                 holder = +arr[i];
//                 arr[i] = +arr[i-1];
//                 arr[i-1] = holder;
//                 found = true;
//             }
//         }
//         aOff++;
//     } while (found);
//     console.log(arr.reverse().join(' '));
// }