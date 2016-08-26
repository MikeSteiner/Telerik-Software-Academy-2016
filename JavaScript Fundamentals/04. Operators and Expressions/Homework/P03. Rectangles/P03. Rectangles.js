/*
 Rectangles

 Description

 Implement a javascript function that takes an argument array as a parameter and calculates rectangle’s area and perimeter by given width and height. The width and height will both be passed in the argument array.

 Input
 •The array that will be passed as argument will always have exactly 2 elements: ◦The first element - a floating-point number that will represent the width of the rectangle.
 ◦The second element - another floating-point number that will represent the height of the rectangle.


 Output
 •Output a single line - the rectangle's area and perimeter, separated by a whitespace. ◦Print the area and perimeter values with exactly 2-digits precision after the floating point.

 •You can use  console.log  to print the results or you can use  return  to return the answer. Both are correct.

 Constraints
 •The width and height will always be valid floating-point numbers.
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests


 Input

 Output

 2.5
 3 7.50 11.00
 5
 5 25.00 20.00
 3
 4 12.00 14.00

 Submission

 */


// var input = [2.5, 3, 5, 5, 3, 4];
// solve(input);

function solve(args) {

    var argsLen = args.length;
    for(var i = 0; i < argsLen; i = i + 2){
        var w = args[i];
        var h = args[i + 1];
    }

    var area = RectangleArea(w, h);
    var perimeter = RectanglePerimeter(w, h);

    console.log(area.toFixed(2) + " " + perimeter.toFixed(2));

    function RectangleArea(width, height){
        width = parseFloat(width);
        height = parseFloat(height);
        var area = width * height;

        return area;
    }

    function RectanglePerimeter(width, height){
        width = parseFloat(width);
        height = parseFloat(height);
        var perimeter = (width * 2) + (height * 2);

        return perimeter;
    }
}



