/**
 * Created by admin on 31.8.2016 г..
 */
'use strict';

// A inherits B
//
// obj = new A();

class Shape{
    constructor(top, left){
        // this._top = top;
        this.top = top;
        this._left = left;
    }

    get top(){
        return this._top;
    }

    set top(top){
        this._top = top;
    }

    usless(){
        console.log("I'm MORE usless!");
    }

    toString(){
        // return "Top: " + this._top + "; Left: " + this._left;
        return "Top: " + this.top + "; Left: " + this._left;
    }
}

class  Rect extends Shape{
    constructor(top, left, width, height){
        super(top, left);
        this._width = width;
        this._height = height;
    }


    toString(){
        return super.toString() + " " + "Width: " + this._width + "; Height: " + this._height;
    }
}

var myRectangle = new Rect(5, 10, 100, 50);
console.log("This is from the myRectangle: " + myRectangle.toString());

var str1 = myRectangle.__proto__.usless();
console.log(str1)

class Square extends Rect{
    constructor(top, left, side) {
        super(top, left, side, side);
    }

    toString(){
        return super.toString();
    }
}

var mySquare = new Square(5, 10, 20);
var str2 = mySquare.toString();
console.log("This is from the mySqare: " + str2);

// ---------------------------
var nameSymbol = Symbol("name");

var obj = {
    "name": "John",
    [nameSymbol]: "Doe"
}

// ---------------------------
// TODO check how is done
function Person(name) {

    getName(){
        console.log(name);
    },
    setName(){

    }

}
// ---------------------------