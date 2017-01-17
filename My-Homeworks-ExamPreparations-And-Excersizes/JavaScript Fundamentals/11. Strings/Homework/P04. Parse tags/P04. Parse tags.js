/**
 * Created by Admin on 1.7.2016 г..
 */

/*
 Parse tags

 Description

 You are given a text. Write a function that changes the text in all regions:
 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <orgcase>text</orgcase> does not change casing


 Note: Regions can be nested.

 Input
 •The input will consist of an array containing one string

 Output
 •The output should be consisted of one line

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Input

 [ 'We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.' ]

 Output
 We are liViNg in a YELLOW SUBMARINE. We doN't have anything else.
 */

function solve(args) {
    //console.log(args);
    var text = "" + args[0];
    var transformedText = "";


    String.prototype.paddLeft = function (count, char) {
        char = char || ' ';
        if(char.length > 1) return String(this);
        if(char.length >= count) return String(this);
        var s = String(this);
        for (var i = 0, len = this.len; i < count - len; i++) {
            s = char + s;
        }

        return s;
    }

    String.prototype.paddRight = function (count, char) {
        char = char || " ";
        if(char.length > 1){
            return String(this);
        }
        if(char.length > count){
            return String(this);
        }
        var s = String(this);

        for(var i = this.length, len = this.length; i > this.length - len; i-=1){
            s = s + char;
        }

        return s;
    }

    String.prototype.trimRight = function (count, char) {
        char = char || ' ';
        count = parseInt(count);

        if(char.length > 1) return String(this);
        if((this.length - char.length) * count < 0) return String(this);
        var s = "";
        for (var i = 0, len = this.length; i < len - count; i+=1) {
            s = s + this[i];
        }

        return s;
    }

    String.prototype.trimLeft = function (count, char) {
        char = char || ' ';
        count = parseInt(count);

        if(char.length > 1) return String(this);
        if((this.length - char.length) * count < 0) return String(this);
        var s = "";
        for (var i = this.length - 1, len = char.length; i >= len * count; i-=1) {
            s = this[i] + s;
        }

        return s;
    }

    function updateTagContent(tagName, tagContent) {

        if(tagName === "upcase"){
            return tagContent.toUpperCase();
        }
        else if(tagName === "lowcase"){
            return tagContent.toLowerCase();
        }

        return tagContent;
    }

    // var pattern = /(<.*?[^>]+>)([^<]+)(<\/.*?>)/gm;
    var pattern = /(<.*?>)([^<]+)(<\/.*?>)/gm;

    var match;
    var startIx = 0, plainTextLen;
    var plainText = "", tagName = "", tagContent = "";
    while(match = pattern.exec(text)){
        //console.log(match);

        // Extract plain text before the match
        plainTextLen = match.index - startIx;
        plainText = text.substr(startIx, plainTextLen)
        //console.log(plainText);

        // Extract the tag value
        tagName = match[1].trimRight(1, ">").trimLeft(1, "<");
        //console.log(tagName);

        // Extract the tag content
        tagContent = match[2];
        //console.log(tagContent);

        // Update the tag content according to the tag value
        tagContent = updateTagContent(tagName, tagContent);

        // Prepare result and update index
        transformedText = transformedText + plainText + tagContent;
        startIx = startIx + plainTextLen + match[0].length;
    }
    plainText = text.substr(startIx);
    transformedText = transformedText + plainText

    console.log(transformedText);



}

// var someHtmlString = "<script>alert('hi!');</script>";
// var input = [ `We are <orgcase> liViNg  in a `];
var input = [ 'We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.' ];
solve(input);