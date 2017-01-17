/**
 * Created by Admin on 29.6.2016 г..
 */
/**
 * Appearance count

 Description

 Write a method that counts how many times given number appears in a given array.
 Write a test program to check if the method is working correctly.

 Input
 •On the first line you will receive a number N - the size of the array
 •On the second line you will receive N numbers separated by spaces - the numbers in the array
 •On the third line you will receive a number X

 Output
 •Print how many times the number X appears in the array

 Constraints
 •1 <= N <= 1024
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 8
 28 6 21 6 -7856 73 73 -56
 73

 2

 Submission

 */

// var input = `8
// 28 6 21 6 -7856 73 73 -56
// 73`;

// var input = [ '8', '28 6 21 6 -7856 73 73 -56', '73' ];
// solve(input);

function solve(args) {

    var N = parseInt(args[0]);
    var countedValue = parseInt(args[2]);
    var inputArr = ("" + args[1]);
    inputArr = inputArr.replace(/(\r\n|\n|\r)/g," ");
    inputArr = inputArr.trim(function (s) {
            var sTrim = s.trim();
            var ret = sTrim !== undefined && sTrim !== null && sTrim !== NaN;
            return ret;
        });
    inputArr = inputArr.split(/\s+/g);
    inputArr = inputArr.map(function (item) {
            return parseInt(item, 10);
        });

    // var N = parseInt(inputArr[0]);
    // var countedValue = inputArr[inputArr.length - 1];
    var numbers = new Array();
     for (i = 0; i < N; i = i + 1) {
        numbers[i] = inputArr[i];
    }

    var counter = appearanceCounter(numbers, countedValue);

    console.log(counter);


    function appearanceCounter(arrToSearch, valueToCount) {
        var bestCount = 0;
        for(i = 0; i < arrToSearch.length; i = i +1){
            var isMatch = (arrToSearch[i] === valueToCount);
            if (isMatch){
                bestCount = bestCount + 1;
            }
        }

        return bestCount;
    }

}


/**
 * Copied
 */
// function solve(params) {
//     var arr = (params + '').split('\n');
//     var arrToSearch = arr[1].split(' ');
//     var count = 0;
//     for(var i = 0; i < arrToSearch.length; i+=1){
//         if (+arrToSearch[i] == +arr[2]) {
//             count++;
//         }
//     }
//     console.log(count);
// }