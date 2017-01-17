/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 Youngest person

 Description

 Write a function that finds the youngest person in a given array of people and prints his/hers full name. Each person has properties  firstname ,  lastname  and  age .

 Example:

 var people = [
 { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname: 'Bay', lastname: 'Ivan', age: 81 },
 { firstname: 'John', lastname: 'Doe', age: 42 }
 ];

 Input
 •The input will consist of an array containing 3 * N values ◦N is the number of people
 ◦Values represent  firstname ,  lastname ,  age , ...


 Output
 •The output should be consisted of one line ◦The full name of the youngest person


 Constraints
 •Time limit: 0.2s
 •Memory limit: 16MB

 Sample tests

 Sample Test 1

 Input

 [
 'Gosho', 'Petrov', '32',
 'Bay', 'Ivan', '81',
 'John', 'Doe', '42'
 ]

 Output
 Gosho Petrov


 Sample Test 2

 Input

 [
 'Penka', 'Hristova', '61',
 'System', 'Failiure', '88',
 'Bat', 'Man', '16',
 'Malko', 'Kote', '72'
 ]

 Output
 Bat Man

 */

function solve(args) {

    var Person = function (firstName, lastName, age) {
        this.firstName = "" + firstName;
        this.lastName = "" + lastName;
        this.age = parseInt(age);
        this.fullName = this.firstName + " " + this.lastName;
    };

    var Persons = new Array();
    var personsCount = 0;
    for(var i = 0; i < args.length; i += 3){
        Persons.push(new Person(args[i], args[i + 1], args[i + 2]));

        personsCount += 1;
    }

    var youngestIx = -1;
    var minPersonAge = 1000;
    for(var pIx = 0; pIx < Persons.length; pIx+=1){

        var isBestYoungestPerson = (Persons[pIx].age < minPersonAge);
        if (isBestYoungestPerson){
            youngestIx = pIx;
            minPersonAge = Persons[pIx].age;
        }
    }

    console.log(Persons[youngestIx].fullName);
}

// var input = [ 'Gosho', 'Petrov', '32', 'Bay', 'Ivan', '81', 'John', 'Doe', '42' ];
// solve(input);
var input = [ 'Penka',
    'Hristova',
    '61',
    'System',
    'Failiure',
    '88',
    'Bat',
    'Man',
    '16',
    'Malko',
    'Kote',
    '72' ];
solve(input);