/**
 * Created by Admin on 19.6.2016 г..
 */
/*
 Prime check

 Description

 Implement a javascript function that accepts an array containing an integer N as string (which will always be less than 100 or equal)
 and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
 •Note: You should check if the number is positive.

 Input
 •The only element of the array will be the integer N as a string value.

 Output
 •Output true if the number is prime and false otherwise.
 •You can use  console.log  to print the results or you can use  return  to return the answer. Both are correct.

 Constraints
 •N will always be a valid 32-bit integer number, which will be less than 100 or equal.
 •Time limit: 0.1s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 2 true
 23 true
 -3 false
 0 false
 1 false
 7 true

 Submission
 */



// var input = [2, 23, -3, 0, 1, 7];
// solve(input);

function solve(args) {

    var argsLen = args.length;
    for(var i = 0; i < argsLen; i = i + 1){
        var N = args[i];
    }

    var isNumPrime = IsPrimeCheck(N);
    if(isNumPrime){
        console.log("true");
    }
    else{
        console.log("false");
    }


    function IsPrimeCheck(number) {
        var isPrime = false;

        number = parseInt(number);

        if(number <= 1){
            return false;
        }

        isDivByItself = (number % number === 0);
        isDivByOne = (number % 1 === 0);
        if(isDivByItself && isDivByOne){
            isPrime = true;
        }


        return isPrime;
    }


}