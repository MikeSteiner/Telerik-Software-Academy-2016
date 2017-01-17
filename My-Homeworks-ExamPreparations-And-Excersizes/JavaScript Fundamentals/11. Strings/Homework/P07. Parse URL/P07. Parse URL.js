/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 Parse URL

 Description

 Write a script that parses an URL address given in the format:  [protocol]://[server]/[resource]  and extracts from it the  [protocol] ,  [server]  and  [resource]  elements.

 Input
 •The input will consist of an array containing one string

 Output
 •The output should be consisted of three line

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Input

 [ 'http://telerikacademy.com/Courses/Courses/Details/239' ]

 Output
 protocol: http
 server: telerikacademy.com
 resource: /Courses/Courses/Details/239
 */

function solve(args) {
    //console.log(args);

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

    var url = "" + args[0];
    var protocol = "";
    var server = "";
    var domainExt = "";
    var resource = "";

    var pattern = /(^.+:\/\/)|([^\/\r\n]+)|(\/[^\r\n]*)?/gi;
    var match = url.match(pattern);

    protocol = match[0].trimRight(2, "/").trimRight(1, ":");
    server = match[1];
    resource = match[2];

    console.log("protocol: " + protocol);
    console.log("server: " + server);
    console.log("resource: " + resource);

}


// var input =  [ 'http://telerikacademy.com/Courses/Courses/Details/212' ];
// var input =  [ 'https://github.com/gentoo/gentoo.git' ];
// var input =  [ 'ftp://github.com/gentoo/gentoo.git' ];
var input =  [ 'https://www.mike.git.h u b.com/gentoo/gentoo.git' ];
solve(input);
