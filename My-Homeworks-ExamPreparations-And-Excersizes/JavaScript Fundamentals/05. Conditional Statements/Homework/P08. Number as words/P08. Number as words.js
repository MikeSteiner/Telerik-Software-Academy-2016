/**
 * Created by Admin on 23.6.2016 г..
 */
/*
 Number as words

 Description

 Write a script that converts a number in the range  [0…999]  to words, corresponding to its English pronunciation.

 Input
 •The input will consist of an array containing the number as a string

 Output
 •The output should be a single line containing the answer

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 0 Zero
 9 Nine
 10 Ten
 12 Twelve
 19 Nineteen
 25 Twenty five
 98 Ninety eight
 273 Two hundred and seventy three
 400 Four hundred
 501 Five hundred and one
 617 Six hundred and seventeen
 711 Seven hundred and eleven
 999 Nine hundred and ninety nine
 */

// var input = [2.5, 3, 5, 5, 3, 4];
// solve(input);

function solve(args) {

    // var argsLen = args.length;
    // for(var i = 0; i < argsLen; i = i + 2){
    //     var w = args[i];
    //     var h = args[i + 1];
    // }

    var N = args[0];

    numberAsWord(N);

    function numberAsWord(num) {
        var numToString = new Array();

        numToString[0] = "zero";
        numToString[1] = "one";
        numToString[2] = "two";
        numToString[3] = "three";
        numToString[4] = "four";
        numToString[5] = "five";
        numToString[6] = "six";
        numToString[7] = "seven";
        numToString[8] = "eight";
        numToString[9] = "nine";
        numToString[10] = "ten";
        numToString[11] = "eleven";
        numToString[12] = "twelve";
        numToString[13] = "thirteen";
        numToString[14] = "fourteen";
        numToString[15] = "fifteen";
        numToString[16] = "sixteen";
        numToString[17] = "seventeen";
        numToString[18] = "eighteen";
        numToString[19] = "nineteen";

        numToString[20] = "twenty";
        numToString[30] = "thirty";
        numToString[40] = "fourty";
        numToString[50] = "fifthy";
        numToString[60] = "sixty";
        numToString[70] = "seventy";
        numToString[80] = "eighty";
        numToString[90] = "ninety";

        var result;
        var numInt = parseInt(num);

        if (numInt >= 0 && numInt <= 20)
        {
            result = numToString[numInt];
        }
        else if ((numInt >= 21 && numInt <= 99))
        {
            var num2 = numInt % 10;
            num2 = parseInt(num2);
            var num1 = numInt / 10;
            num1 = parseInt(num1);

            result = numToString[num1 * 10] + " " + numToString[num2];
        }
        else if ((numInt >= 100 && numInt <= 999))
        {
            var num3 = numInt / 100;
            num3 = parseInt(num3);
            num2 = (numInt / 10) % 10;
            num2 = parseInt(num2);
            num1 = numInt % 10;
            num1 = parseInt(num1);

            var resAnd = " and";
            var res3 = numToString[num3] + " hundred";
            var res2 = " " + numToString[num2 * 10];
            var res1 = " " + numToString[num1];

            if (num2 == 0){
                res2 = "";
            }
            if (num1 == 0){
                res1 = "";
            }
            if (num2 == 0 && num1 == 0){
                resAnd = "";
            }

            if (num2 > 1)
            {
                result = res3 + resAnd + res2 + res1;
            }
            else
            {
                num2 = num2 * 10 + num1;
                res2 = " " + numToString[num2];

                if (num2 == 0){
                    res2 = "";
                }

                result = res3 + resAnd + res2;
            }
        }

        result = Capitalize(result);
        console.log(result);

    }

    function Capitalize(stringToCapitalize)
    {
        return stringToCapitalize[0].toUpperCase() + stringToCapitalize.slice(1);
    }
}



