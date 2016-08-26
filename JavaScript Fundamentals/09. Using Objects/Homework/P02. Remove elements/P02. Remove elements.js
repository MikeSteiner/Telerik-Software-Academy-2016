/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 Remove elements

 Description

 Write a function that removes all elements with a given value. Attach it to the array type. Read about prototype and how to attach methods.

 var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
 arr.remove(1); // arr = [2,4,3,4,111,3,2,'1'];

 You will be given an array of strings. Remove all occurrences of the first element in the array in itself.

 Input
 •The input will consist of an array of strings

 Output
 •The output should be the array with some elements removed ◦Each string should be on a separate line


 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Sample Test 1

 Input

 [ '1', '2', '3', '2', '1', '2', '3', '2' ]

 Output
 2
 3
 2
 2
 3
 2


 Sample Test 2

 Input

 [
 '_h/_',
 '^54F#',
 'V',
 '^54F#',
 'Z285',
 'kv?tc`',
 '^54F#',
 '_h/_',
 'Z285',
 '_h/_',
 'kv?tc`',
 'Z285',
 '^54F#',
 'Z285',
 'Z285',
 '_h/_',
 '^54F#',
 'kv?tc`',
 'kv?tc`',
 'Z285'
 ]

 Output
 ^54F#
 V
 ^54F#
 Z285
 kv?tc`
 ^54F#
 Z285
 kv?tc`
 Z285
 ^54F#
 Z285
 Z285
 ^54F#
 kv?tc`
 kv?tc`
 Z285
 */

function solve(args) {
    var valueToRemove = args[0];
    var allElementsArr = args.splice(0);
    allElementsArr.shift();
    var removedElementsArr = new Array();

    //**********
    // Object.defineProperty(Array.prototype, "stackoverflow_remove", {
    //     // Specify "enumerable" as "false" to prevent function enumeration
    //     enumerable: false,
    //
    //     /**
    //      * Removes all occurence of specified item from array
    //      * @this Array
    //      * @param itemToRemove Item to remove from array
    //      * @returns {Number} Count of removed items
    //      */
    //     value: function (itemToRemove) {
    //         // Count of removed items
    //         var removeCounter = 0;
    //
    //         // Iterate every array item
    //         for (var index = 0; index < this.length; index++) {
    //             // If current array item equals itemToRemove then
    //             if (this[index] === itemToRemove) {
    //                 // Remove array item at current index
    //                 this.splice(index, 1);
    //
    //                 // Increment count of removed items
    //                 removeCounter++;
    //
    //                 // Decrement index to iterate current position
    //                 // one more time, because we just removed item
    //                 // that occupies it, and next item took it place
    //                 index--;
    //             }
    //         }
    //
    //         // Return count of removed items
    //         return removeCounter;
    //     }
    // });
    //**********

    Object.defineProperty(Array.prototype, "removeElementsByValue", {
        // Specify "enumerable" as "false" to prevent function enumeration
        enumerable: false,
        //Remove all occurrence of specified item by its value
        value: function (valToRem) {
            var remCounter = 0;
            var currElement;

            for(var i = 0; i < this.length; i += 1){
                currElement = this[i];
                var isToBeRemoverElement = (currElement === valToRem);
                if(isToBeRemoverElement){
                    this.splice(i, 1);

                    remCounter += 1;
                    i -= 1;
                }
            }

            return remCounter;
        }
    });

    var count = allElementsArr.removeElementsByValue(valueToRemove);
    removedElementsArr = allElementsArr.splice(0);
    console.log(removedElementsArr.join("\n"));
}

// var input = [ '1', '2', '3', '2', '1', '2', '3', '2', '1' ];
// solve(input);
var input = [ '_h/_',
    '^54F#',
    'V',
    '^54F#',
    'Z285',
    'kv?tc`',
    '^54F#',
    '_h/_',
    'Z285',
    '_h/_',
    'kv?tc`',
    'Z285',
    '^54F#',
    'Z285',
    'Z285',
    '_h/_',
    '^54F#',
    'kv?tc`',
    'kv?tc`',
    'Z285' ];
solve(input);
