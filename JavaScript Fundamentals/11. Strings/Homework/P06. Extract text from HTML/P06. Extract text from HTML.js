/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 Extract text from HTML

 Description

 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.

 Input
 •The input will consist of an array of strings

 Output
 •The output should be consisted of one line - text inside tags

 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Input

 [
 '<html>',
 '  <head>',
 '    <title>Sample site</title>',
 '  </head>',
 '  <body>',
 '    <div>text',
 '      <div>more text</div>',
 '      and more...',
 '    </div>',
 '    in body',
 '  </body>',
 '</html>'
 ]

 Output
 Sample sitetextmore textand more...in body


 */

// function solve(args) {
//     let output = '';
//     let matchTags = /<.*?>/ig;
//
//     for (let line of args) {
//         output += line.replace(matchTags, '').trim();
//     }
//
//     console.log(output);
// }

function solve(args) {
    //console.log(args);

    var textHtml = "";
    var pattern = /<.*?>/gi;

    for(var i = 0; i < args.length; i+=1){
        textHtml += args[i].replace(pattern, "").trim();
    }

    console.log(textHtml);
}

var input =  [
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
];

solve(input);