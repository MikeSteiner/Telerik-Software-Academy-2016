/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 Planar coordinates

 Description

 Write functions for working with shapes in standard Planar coordinate system.
 •Points are represented by coordinates
 •Lines are represented by two points, marking their beginning and ending.
 You will be given three line segments.
 Calculate their length. Check if the line segments can form a triangle.

 Input
 •The input will consist of an array containing twelve values ◦Line 1, Point 1 X
 ◦Line 1, Point 1 Y
 ◦Line 1, Point 2 X
 ◦Line 1, Point 2 Y
 ◦Line 2, Point 1 X
 ◦...


 Output
 •The output should be consisted of four lines ◦Three lines showing the length of each line segment
 ◾Use 2 digits of precision

 ◦Fourth line should be one of:
 ◾ Triangle can be formed
 ◾ Triangle can't be formed 



 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Sample Test 1

 Input

 [
 '5', '6', '7', '8',
 '1', '2', '3', '4',
 '9', '10', '11', '12'
 ]

 Output
 2.83
 2.83
 2.83
 Triangle can be built


 Sample Test 2

 Input

 [
 '7', '7', '2', '2',
 '5', '6', '2', '2',
 '95', '-14.5', '0', '-0.123'
 ]

 Output
 7.07
 5.00
 96.08
 Triangle can not be built


 Submission
 */

function solve(args) {
    // console.log(args);

    //var points = {};
    var lines = new Object();

    // var myHonda = {color: "red", wheels: 4, engine: {cylinders: 4, size: 2.2}};
    lines = [
        {length : 0,
            pointA : {x : args[0], y : args[1]}, pointB : {x : args[2], y : args[3]}},
        {length : 0,
            pointA : {x : args[4], y : args[5]}, pointB : {x : args[6], y : args[7]}},
        {length : 0,
            pointA : {x : args[8], y : args[9]}, pointB : {x : args[10], y : args[11]}}
    ];

    // var distance = calcutateDistance(lines[0].pointA, lines[0].pointB);
    // console.log(distance);
    for(var i = 0; i < lines.length; i += 1){
        lines[i].length = calcutateDistance(lines[i].pointA, lines[i].pointB);
        console.log(lines[i].length.toFixed(2));
    }

    var canBeBuildTriangle = (lines[0].length + lines[1].length > lines[2].length)
                            && (lines[1].length + lines[2].length > lines[0].length)
                            && (lines[2].length + lines[0].length > lines[1].length);

    if(canBeBuildTriangle){
        console.log("Triangle can be built");
        return;
    }
    console.log("Triangle can not be built");

    function calcutateDistance(pA, pB) {

        pA.x = parseFloat(pA.x);
        pA.y = parseFloat(pA.y);

        pB.x = parseFloat(pB.x);
        pB.y = parseFloat(pB.y);

        var deltaX = Math.max(pA.x, pB.x) - Math.min(pA.x, pB.x);
        var deltaY = Math.max(pA.y, pB.y) - Math.min(pA.y, pB.y);
        var dist = Math.sqrt((deltaX * deltaX) + (deltaY * deltaY));

        return dist;
    }
}

// var input = [ '5', '6', '7', '8', '1', '2', '3', '4', '9', '10', '11', '12' ];
// solve(input);
var input = [ '7', '7', '2', '2', '5', '6', '2', '2', '95', '-14.5', '0', '-0.123' ];
solve(input);

