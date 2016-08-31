/**
 * Created by admin on 31.8.2016 г..
 */
// Mixin examples

// class Rect {
//     constructor(){
//     }
//     getArea(){
//         return this.width * this.height;
//     }
// }

function Rect(width, height) {
    this.width = width;
    this.height = height;

    this.getArea = function () {
        //....
    }
}

Rect.prototype.getArea = function () {
    return this.height * this.width;
}


// Old style mixin
// ----------------------
class Mamel{
    constructor(name){
        this.name = name;
    }
}

class Person extends Mamel{
    constructor(name){
        super(name);
    }

    introduce(){
        console.log("Hi my name is " + this.name);
    }
}

class  Frog extends Parent{
    constructor(name){
        this.name = name;
    }
}

var hasPrintNameMixin = {
    printName(){
        console.log("my name is " + this.name);
    },
    printAge(){
         console.log("15");
    }
}

Person.prototype.printName() = hasPrintNameMixin[];

// Appends all the
Object.keys(hasPrintNameMixin){
    .forEach(prop => {
        Person.prototype[prop] =
            mixin[prop];

    });
}

