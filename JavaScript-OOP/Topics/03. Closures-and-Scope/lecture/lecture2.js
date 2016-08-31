/**
 * Created by admin on 29.8.2016 г..
 */
'use strict';

class Horse{

    // var name = '';

    constructor(name, furColor, age, friends) {
        console.log('Horse created');
        this._name = name;
        this._furColor = furColor;
        this._age = age;
        // not a good practice should be in a different class
        this._friends = friends;

        this.numberOfLegs = 4;
    }

    // Old thype setter
    setName(newName){

        var nameIsValid = (newName !== NaN);
        if(!nameIsValid){
            throw  new  Error('name must be string');
        }
        this._name = newName;
    }

    get name(){
        return this._name;
    }

    // New type of setter
    set name(value){
        var nameIsValid = (value !== NaN);
        if(!nameIsValid){
            throw  new  Error('name must be string');
        }
        this._name = value;
    }

    printFriends(){
        // this._friends.forEach(function (friend) => {
        //         console.log(friend.name);
        //     });
    }

    makeSound(){
        console.log(this._name + ' ney ney ney!');
    }

    toString(){
        return this._name + ' is a ' + this._furColor + ' horce ' + this._age + ' yesrs old';
    }
}

var trendafil = new Horse('Trendafil', 'broun', 5);

trendafil.setName('Boil');
trendafil.name = 'Trendafil again';


var vihar = new Horse('Vihar', 'white', 3);



// console.log(typeof Horse);
console.log(trendafil.toString());
console.log(trendafil.makeSound());


// !!!
const arr = [1, 2, 3, 4];
function forEach(callback) {
    for(const value of this){
        callback(value);
    }
}

forEach.call(arr, x => console.log(x));