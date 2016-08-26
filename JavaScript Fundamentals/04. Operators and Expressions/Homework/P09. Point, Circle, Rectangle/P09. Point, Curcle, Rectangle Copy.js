
/**
 * Created by Admin on 22.6.2016 г..
 */


function solve(args) {

    // argsLen = args.length;
    // for(var i = 0; i < argsLen; i=i+1){
    //     var n = +args[i];
    //
    //    
    // }

    var c1 = args[0];
    var c2 = args[0];
    var r = args[0];
}

function isInCircleOutRect(coord1, coord2, result) {
    
    var circle1 = 1;
    var circle2 = 1;
    var rect1topX = 1;
    var rect1topY = -1;
    var rectW = 6;
    var rectH = 2;
    var radius = 3;

    if (isNaN(coord1) || isNaN(coord2)) {
        result.value = "NaN";
        return;
    }

    if((isInCircleCheck(circle1, circle2, coord1, coord2, radius) <= 0) && (!isInRectangleCheck(rect1topX, rect1topY, rectW, rectH, coord1, coord2)))
        result.value = "TRUE";
    else
        result.value = "FALSE";
}

function isInCircleCheck(Xc, Yc, Xp, Yp, radius) {
    var distance = (Xp - Xc)*(Xp - Xc) + (Yp - Yc)*(Yp - Yc);
    return (distance - radius*radius);
}

function isInRectangleCheck(Xr, Yr, W, H, Xp, Yp) {
    //top left corner
    var Ax = Xr;
    var Ay = Yr;
    //bottom right corner
    var Cx = Xr + W;
    var Cy = Yr - H; //since we are counting up from the top left corner the rectangle expands downwards

    if ((Xp-Ax)*(Xp-Cx) <= 0 && (Yp - Ay)*(Yp - Cy) <= 0)
        return true;

    return false;
}