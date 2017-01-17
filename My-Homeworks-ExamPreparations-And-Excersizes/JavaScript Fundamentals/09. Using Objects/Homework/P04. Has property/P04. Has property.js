/**
 * Created by Admin on 1.7.2016 г..
 */
/*
 Has property

 Description

 Write a function that checks if a given object contains a given property.

 var obj  = …;
 var hasProp = hasProperty(obj, 'length');

 Submission
 •You do not have to submit anything for this problem
 */

function solve(args) {
    // var myHonda = {color: "red", wheels: 4, engine: {cylinders: 4, size: 2.2}};
    // var Employee = function(name, title) {
    //     Person.call(this);
    //     this.name = name;
    //     this.title = title;
    // };

    var Person = function (firstName, lastName, age, gender) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
    };

    var Alex = new Person("Alex", "Valadislavov", 36, "male");
    var Peter = new Person("Peter", "Peterson", 33, "mail");
    var LadyGaga = new Person("Lady", "Gaga", 22, "femail");

    console.log(Alex);
    console.log(Peter);
    console.log(LadyGaga);

    Object.defineProperty(Person.prototype, "hasPropertyMyExtension", {
        enumerable : false,
        value : function(propertyName) {
            propertyName = "" + propertyName;

            if(this.hasOwnProperty(propertyName)){
                return true;
            }

            return false;
        }
    });

    Person.prototype.fullName = function () {
        return this.firstName + " " + this.lastName;
    };

    console.log(Alex.hasPropertyMyExtension("as"));
    console.log(Alex.hasPropertyMyExtension("age"));
    console.log(Alex.fullName());

}

solve(1);