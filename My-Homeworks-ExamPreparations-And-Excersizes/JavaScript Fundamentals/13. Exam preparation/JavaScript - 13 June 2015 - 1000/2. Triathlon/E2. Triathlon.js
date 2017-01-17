/**
 * Created by Admin on 3.7.2016 г..
 */

function solve(args) {
    // console.log(args);
    var result;
    var text = args[0];
    var offset = args[1];
    var CONSTANTS = {
            ALPHABET: 'abcdefghijklmnopqrstuvwxyz'
        };

    function compressText(inText) {
        var comprText = "";
        var textToAppend = "";
        var prevCh = "", currCh = "";

        for(var i = 1; i < inText.length + 1; i += 1){
            // Get the previous and the current element
            prevCh = inText[i - 1];
            currCh = inText[i];

            // Count same chars.
            // While there is a sequence of same elements,
            // increment counter and get curret element
            var seqOfSameCh = 1;
            var areSameCh = (prevCh === currCh);
            while(areSameCh){
                seqOfSameCh += 1;
                i += 1;
                currCh = inText[i];

                areSameCh = (prevCh === currCh);
            }

            // Select which char an how many time to nbe appended
            if(seqOfSameCh === 1){
                textToAppend = prevCh;
            }else if(seqOfSameCh === 2){
                textToAppend = prevCh + prevCh;
            }else{
                textToAppend = "" + seqOfSameCh + prevCh;
            }

            comprText += textToAppend;
        }

        return comprText;
    }

    function encryptText(inText, ofs) {
        var encryptTextResult = "";

        ofs = parseInt(ofs);
        var cypher = prepareCypher(ofs);

        for(var i = 0; i < inText.length; i+=1){
            var ch = inText[i];

            var isDigit = (parseInt(ch) >= 0) && (parseInt(ch) <=9 )
            if(isDigit){
                encryptTextResult += "" + ch;
            }else{
                var currChAscii = ("" + ch).charCodeAt(0);
                var cypherChAscii = ("" + (cypher[currChAscii - 97])).charCodeAt(0);
                var xorResult = currChAscii ^ cypherChAscii;

                encryptTextResult += "" + xorResult;
            }
        }

        return encryptTextResult;
    }

    function prepareCypher(ofs) {
        var alphabetOffseted = new Array();
        alphabetOffseted = CONSTANTS.ALPHABET.split("");

        for(var i = 0; i < ofs; i+=1){
            var ch = alphabetOffseted.pop();
            alphabetOffseted.unshift(ch);
        }

        return alphabetOffseted;

    }

    function textTransformation(encryptedNum) {
        var encryptedNum = encryptedNum.split("").map(function (digitStr) {
            return parseInt(digitStr);
        });

        var sum = 0;
        var prod = 1;

        for(var i = 0; i < encryptedNum.length; i+=1){
            // Find the sum of all even digits and the product of all odd digits in the encryption
            var currValue = encryptedNum[i];
            var isEven = (currValue % 2 == 0);
            if(isEven){
                sum += currValue;
            }else{
                prod *= currValue;
            }
        }

        console.log(sum);
        console.log(prod);
    }

    // Call function for compression
    var compressedText = "" + compressText(text);
    // console.log(compressedText);
    // Call function for encryption
    var encryptedText = encryptText(compressedText, offset);
    // console.log(encryptedText);
    // Call function for text transformation
   textTransformation(encryptedText);

}

var input = [ 'aaaabbbccccaa', '3' ];
solve(input);

