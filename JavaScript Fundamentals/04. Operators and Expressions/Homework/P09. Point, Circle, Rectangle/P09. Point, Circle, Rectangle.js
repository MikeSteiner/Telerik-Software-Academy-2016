/**
 * Created by Admin on 19.6.2016 г..
 */
/*
 Point, Circle, Rectangle

 Description

 Implement a javascript function that accepts an array with a pair of coordinates x and y and uses an expression to checks
 for given point (x, y) if it is within the circle  K({1, 1}, 1.5)  and out of the rectangle  R(top=1, left=-1, width=6, height=2) .

 Input
 •You will receive the pair of coordinates as two elements of an array - the first element will be x, and the second - y.

 Output
 •Print inside circle if the point is inside the circle and outside circle if it's outside.
 Then print a single whitespace followed by inside rectangle if the point is inside the rectangle and outside rectangle otherwise. See the sample tests for a visual description. ◦You can use  console.log  to print the results or you can use  return  to return the answer. Both are correct.


 Constraints
 •The coordinates x and y will always be valid floating-point numbers in the range  [-1000, 1000] .
 •Time limit: 0.1s
 •Memory limit: 16MB

 Sample tests


 Input

 Output


 2.5
 2 outside circle outside rectangle
 0
 1 inside circle inside rectangle
 2.5
 1 inside circle inside rectangle
 1
 2 inside circle outside rectangle 

 */


// var input = [2.5, 2, 0, 1, 2.5, 1, 1, 2];
// solve(input);

function solve(args) {

    // var argsLen = args.length;
    // for(var i = 1; i < argsLen; i = i + 2){
    //     var x = args[i - 1];
    //     var y = args[i];
    //
    //     var distToCenter = CalcuDistanceToCenter(x, y);
    //     var isInsideCircle = IsInsideCircle(distToCenter, 1.5);
    //     var isInsideRectangle = IsInsideRectangle(x, y);
    //
    //     var resultStr = "";
    //     if(isInsideCircle){
    //         resultStr = "inside circle";
    //     }
    //     else{
    //         resultStr = "outside circle";
    //     }
    //
    //     if(isInsideRectangle){
    //         resultStr = resultStr + " inside rectangle";
    //     }
    //     else{
    //         resultStr = resultStr + " outside rectangle";
    //     }
    //
    //     console.log(resultStr);
    //
    // }

    var x = args[0];
    var y = args[1];

    var distToCenter = CalcuDistanceToCenter(x, y);
    var isInsideCircle = IsInsideCircle(distToCenter, 1.5);
    var isInsideRectangle = IsInsideRectangle(x, y);

    var resultStr = "";
    if(isInsideCircle){
        resultStr = "inside circle";
    }
    else{
        resultStr = "outside circle";
    }

    if(isInsideRectangle){
        resultStr = resultStr + " inside rectangle";
    }
    else{
        resultStr = resultStr + " outside rectangle";
    }

    console.log(resultStr);


    function IsInsideRectangle(x, y) {
        x = parseFloat(x);
        y = parseFloat(y);

        var isInsideX = (x >= -1) && (x <= 6);
        var isInsideY = (y >= -1) && (y <= 1);

        if(isInsideX && isInsideY){
            return true;
        }

        return false;
    }

    function IsInsideCircle(distance, radius) {
        var isInCircle = (distance <= radius);
        if(isInCircle){
            return true;
        }
        else{
            return false;
        }
    }

    function CalcuDistanceToCenter(x, y) {
        x = parseFloat(x);
        y = parseFloat(y);
        var xDisplaysment = 1;
        var yDisplaysment = 1;

        x = Math.abs(x - xDisplaysment);
        y = Math.abs(y - yDisplaysment);

        var H = Math.pow(x, 2.0) + Math.pow(y, 2.0);
        H = Math.sqrt(H);

        return H;
    }
}