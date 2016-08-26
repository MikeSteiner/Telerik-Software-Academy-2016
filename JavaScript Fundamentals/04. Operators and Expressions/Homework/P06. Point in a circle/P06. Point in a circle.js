/**
 * Created by Admin on 19.6.2016 г..
 */
/*
 Point in a circle

 Description

 Implement a javascript function that by given coordinates of a point x and y and using an expression checks
 if given point (x, y)
 is inside a circle  K({0, 0}, 2)  - the center has coordinates (0, 0) and the circle has radius 2.
 The program should then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.
 •In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.

 Input
 •You will receive an array as a parameter. The array will contain exactly 2 string elements, the first being the x coordinate and the second - the y coordinate.

 Output
 •Output a single line in the format described above. The distance should always be printed
 with 2-digits of precision after the floating point.
 •You can use  console.log  to print the results or you can use  return  to return the answer. Both are correct.

 Constraints
 •The numbers x and y will always be valid floating point numbers in the range  (-1000, 1000)
 •Time limit: 0.1s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 -2
 0 yes 2.00
 -1
 2 no 2.24
 1.5
 -1 yes 1.80
 -1.5
 -1.5 no 2.12
 100
 -30 no 104.40
 0
 0 yes 0.00
 0.2
 -0.8 yes 0.82
 0.9
 -1.93 no 2.13
 1
 1.655 yes 1.93
 0
 1 yes 1.00

 Submission
 */


// var input = [-2, 0, -1, 2, 1.5, -1, -1.5, -1.5, 100, -30, 0, 0, 0.2, -0.8, 0.9, -1.93, 1, 1.655, 0, 1];
// solve(input);

function solve(args) {

    // var argsLen = args.length;
    // for(var i = 1; i < argsLen; i = i + 2){
    //     var x = args[i - 1];
    //     var y = args[i];
    //
    //     var distToCenter = CalculateDistance(x, y);
    //     IsInside(distToCenter, 2.0);
    //
    // }
    var x = args[0];
    var y = args[1];

    var distToCenter = CalculateDistance(x, y);
    IsInside(distToCenter, 2.0);

    function IsInside(distance, radius) {
        var isInsideCurcle = (distance <= radius);
        if(isInsideCurcle){
            console.log("yes " + distance.toFixed(2))
        }
        else{
            console.log("no " + distance.toFixed(2));
        }
    }

    function CalculateDistance(x, y) {
        x = parseFloat(x);
        y = parseFloat(y);

        var H = Math.pow(x, 2.0) + Math.pow(y, 2.0);
        H = Math.sqrt(H);

        return H;
    }



}




