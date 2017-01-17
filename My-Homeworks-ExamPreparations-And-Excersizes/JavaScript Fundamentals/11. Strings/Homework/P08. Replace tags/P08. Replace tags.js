/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 Problem 8. Replace tags
 • Write a JavaScript function that replaces in a HTML document given as string all the tags  <a href="…">…</a>  with corresponding tags  [URL=…]…/URL] .

 Example:


 input

 output


 <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course.
 Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

 <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course.
 Аlso visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

 // <p>Please visit [our site](http://academy.telerik.com) to choose a training course.
 // Also visit [our forum](www.devbg.org) to discuss the courses.</p>

 */

function solve(args) {
    //console.log(args);

    var text = "" + args[0];

    var formatedText = text
        //.replace(/\s\s+/g, " ")
        .replace(/(\<a href=['"])(.*?)(['"]\>)(.*?)(\<\/a\>)/gm, "[$4](" +  "$2)");

    console.log(formatedText);
}


var input =  [ `<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course.
    Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>` ];
// var input =  [ 'https://github.com/gentoo/gentoo.git' ];
// var input =  [ 'ftp://github.com/gentoo/gentoo.git' ];
// var input =  [ 'https://www.mike.git.h u b.com/gentoo/gentoo.git' ];
solve(input);