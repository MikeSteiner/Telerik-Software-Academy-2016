/**
 * Created by admin on 31.8.2016 г..
 */
// ES2015 mixin
// ----------------------
class Creature{

}

class Mammal{

}

// Old whay of making mixin
function  HasNameAndAgePrintingMixin(Base) {
    return class extends Base{
        printName(){
            console.log(name);
        }
    }
}
// New Better whay of making mixin
var HasNameAndAgePrintingMixin =
    Base => class extends Base {
        printName(){
            if(typeof this.name === "undefined"){
                throw new Error();
            }
            // super is simply syntatic sugar

            console.log(super);
            console.log(name);
        }
    };



// Person inherits HasNameAndAgeprintingMixin which inheriths trough Base the Mammal
class Person extends HasNameAndAgeprintingMixin(Mammal){
    constructor(name){
        super();
        this.name = name;
    }
}