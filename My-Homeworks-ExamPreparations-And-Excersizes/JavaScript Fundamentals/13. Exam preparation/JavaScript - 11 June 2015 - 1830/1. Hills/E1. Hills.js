/**
 * Created by Admin on 4.7.2016 г..
 */
/*
 Problem 1 - Hills
 The earth is not flat. You are given a series of numbers representing its height at equal intervals. There is a rock in each of those intervals. Over time the rocks on the earth roll down until they gather in the valleys. Your task is to find what will be the maximum number of rocks in a single valley.
 Example (second sample input)
 •	Peaks are in green
 •	Valleys are yellow
 •	Each line has a single rock on it
 Input
 The input data is given as a parameter - an array of strings.
 On the only input line there will be numbers separated by spaces – the heights.
 Output
 The output should be printed on the console.
 Output the maximum number of rocks that will be in a valley.
 Sample solution code (in JavaScript)
 function solve(params) {
 var s = params[0].split(‘ ‘).map(Number),
 result;
 // Your solution here
 console.log(result);
 }
 Constraints
 •	Input contains between 3 and 10 000 numbers
 o	Each of them is ranging from 0 to 100 000
 •	Consecutive numbers are not equal
 •	The first and the last height are peaks
 •	Allowed working time for your program: 0.3 seconds
 •	Allowed memory: 32 MB
 Examples
 Input	Output
 5 1 7 4 8	2	5, 7 and 8 are peaks
 1 and 4 are valleys
 In valley 1:
 •	One rock from the left
 •	One rock from the right
 5 1 7 6 3 6 4 2 3 8	4	5, 7, 6 and 8 are peaks
 1, 3 and 2 are valleys
 In valley 1:
 •	One rock from the left
 •	One rock from the right
 In valley 3:
 •	Two rocks from the left
 •	One rock from the right
 In valley 2:
 •	Two rocks from the left
 •	Two rocks from the right
 10 1 2 3 4 5 4 3 2 1 10	5
 Problem 1 - Hills
 The earth is not flat. You are given a series of numbers representing its height at equal intervals. There is a rock in each of those intervals. Over time the rocks on the earth roll down until they gather in the valleys. Your task is to find what will be the maximum number of rocks in a single valley.
 Example (second sample input)
 •	Peaks are in green
 •	Valleys are yellow
 •	Each line has a single rock on it
 Input
 The input data is given as a parameter - an array of strings.
 On the only input line there will be numbers separated by spaces – the heights.
 Output
 The output should be printed on the console.
 Output the maximum number of rocks that will be in a valley.
 Sample solution code (in JavaScript)
 function solve(params) {
 var s = params[0].split(‘ ‘).map(Number),
 result;
 // Your solution here
 console.log(result);
 }
 Constraints
 •	Input contains between 3 and 10 000 numbers
 o	Each of them is ranging from 0 to 100 000
 •	Consecutive numbers are not equal
 •	The first and the last height are peaks
 •	Allowed working time for your program: 0.3 seconds
 •	Allowed memory: 32 MB
 Examples
 Input	Output
 5 1 7 4 8	2	5, 7 and 8 are peaks
 1 and 4 are valleys
 In valley 1:
 •	One rock from the left
 •	One rock from the right
 5 1 7 6 3 6 4 2 3 8
 4	5, 7, 6 and 8 are peaks
 1, 3 and 2 are valleys
 In valley 1:
 •	One rock from the left
 •	One rock from the right
 In valley 3:
 •	Two rocks from the left
 •	One rock from the right
 In valley 2:
 •	Two rocks from the left
 •	Two rocks from the right
 10 1 2 3 4 5 4 3 2 1 10	5

 */

function solve(args) {
    //console.log(args);

    Array.prototype.sum = function () {
        var s = 0;
        for(var i = 0; i < this.length; i += 1){
            s += this[i];
        }

        return s;
    }

    var numbers = args[0].split(" ").map(Number);
    var rocksInValley = new Array();
    var result = 0;

    // Main loop, Search for valley
    for(var i = 1; i < numbers.length; i += 1){
        var prevElement = numbers[i - 1];
        var currElement = numbers[i];
        var nextElement = numbers[i + 1];

        // TODO Is a valley logic
        var isValley = (prevElement > currElement) && (nextElement > currElement);

        if(isValley){
            var valleyValue = currElement;
            var rockLeftIx = i - 1;
            var rockRightIx = i + 1;
            var rocksCounter = 0;

            // Count rocks on left
            do{
                var isRockOnLeft = (prevElement > valleyValue);
                var holdPrevElement = prevElement;

                if(isRockOnLeft){
                    rocksCounter += 1;
                }

                rockLeftIx -= 1;

                // Check if is inside the array ix >= 0 and i <= numbers.length
                if(rockLeftIx < 0){
                    break;
                }
                prevElement = numbers[rockLeftIx];

            }while (prevElement > valleyValue && (prevElement > holdPrevElement));

            // Count rocks on right
            do{
                var isRockOnRight = (nextElement > valleyValue);
                var holdNextElement = nextElement;

                if(isRockOnLeft){
                    rocksCounter += 1;
                }

                rockRightIx += 1;

                // Check if is inside the array ix >= 0 and i <= numbers.length
                if(rockLeftIx >= numbers.length){
                    break;
                }
                nextElement = numbers[rockRightIx];

            } while (nextElement > valleyValue && (nextElement > holdNextElement));

            // TODO put the counted rocks in the current valley
            rocksInValley.push(rocksCounter);

            // Continue from the most right reached index
            i = rockRightIx - 1;
        }
    }

    // TODO create prototype Array.sum
    //result = rocksInValley.sum();
    result = Math.max.apply(Math, rocksInValley);
    console.log(result);

}

// var input = ['5 1 7 4 8'];
// var input = ['5 1 7 6 3 6 4 2 3 8'];
var input = ['10 1 2 3 4 5 4 3 2 1 10'];
solve(input);