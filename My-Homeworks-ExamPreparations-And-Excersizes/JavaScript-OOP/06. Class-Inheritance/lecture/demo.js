/**
 * Created by admin on 31.8.2016 г..
 */
// Classes
//  Mixins
//  Scope & Closure

let db = (function () {
    let dataStorage = {};
    let lastId = 0;

    // Number 32bit

    let Saveable = Base => class extends Base{
        // reast operator is that one
        constructor(...args){
            // new  N 1, 2, 3

            // spread operator feom arr to non array
            super(...args);
            this.id = (lastId += 1);
        }

        save(){
            // this ->
            console.log("It is saves with name" + this.name);
            console.log(this.constructor.name);

            let typeName = this.constructor.name;
            if(typeName === ""){
                typeName = "anonymous";
            }

            if(dataStorage[typeName]){
                dataStorage[typeName] = [];
            }
            dataStorage[typeName].push(this);
        }

        static all(){
            let typeName = this.name;

            return dataStorage[typeName];
        }

        static findById(id){
            let typeName = this.name;

            return dataStorage[typeName].find(obj => obj.id === id );
        }
    };


    function list(Type) {
        // Type -> Person aor Shape
        console.log(Type.name);

        return dataStorage[Type].name;
    }

    //revealing module pattern
    return {
        Savable,
        list
    };
}());


var p = new Person("John", 18);
p.save();

let count = 5;
// Array.from({length: count }).map((_, i) => new Person)....


class Mammal{
    constructor(age){
        this.age = age;
    }
}

class Person extends Saveable(Object){
    constructor(name, age){
        super();
        this.name = name;
        this.age = age;

    }
}

class Shape extends db.Saveable(){

}

//Person
console.log(db.list(Person));
console.log(db.list(Person));
console.log(db.all());

