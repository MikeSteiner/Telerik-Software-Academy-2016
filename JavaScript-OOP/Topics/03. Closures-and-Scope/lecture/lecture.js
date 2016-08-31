/**
 * Created by admin on 29.8.2016 г..
 */
//'use strict';

(function () {
    var counter = 0;
}());

// console.log('counter '+ counter);

// Better use const than let!
var person = 'persho';
const person2 = 'gosho';
console.log('const ' + person2);

person = 'ivan';
// person2.name = 'ivan2';
console.log('const2 ' + person2.name);



// global variable equal to declared with var
// use strict forbids the declaraion below
// num = 10;
// console.log(num);

function addPartial(x) {
    function inner(y) {
        var partialSum = x + y;
        console.log(partialSum);
        //return partialSum;
    }

    //return inner;
}

//console.log(addPartial(6));
addPartial(5);

// How to copy ojects with JSON
var records = {
    message: 'bad code'
}
JSON.stringify(records);

var copiedRecords = JSON.parse((JSON.stringify(records)));
