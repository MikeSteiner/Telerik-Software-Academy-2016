/**
 * Created by Admin on 5.7.2016 г..
 */

/*
 Game of Trolls


 Telerik Academy Season 2016-2017 / JavaScript Fundamentals Exam - 05 June 2016

 Task 2: Game of Trolls
 Description

 Wboup and Nbslbub play an interesting game with Lsjtujzbo - a Game of Trolls. The idea of the game is the following:

 Wboup and Nbslbub are trolls.
 Lsjtujzbo is a princess.
 The trolls chase the princess on a field that has R rows and C columns. The field's coordinates are zero-based and are counted up to down, left to right - the first row is 0, the second 1, etc. The first column is 0, the second 1 and so on.
 Wboup, Nbslbub and Lsjtujzbo can move in 4 directions - up, down, left and right by 1 step.
 Lsjtujzbo is dangerous - she can lay traps. If a troll steps on a trap, it cannot move out of it, unless another troll comes to help him. If for an example Nbslbub falls in a trap, then he cannot move(even if there is such command) until Wboup stands in the same cell as well. When Nbslbub is rescued from the trap, the trap is destroyed and he can move freely again.
 The goal of the princess is to escape the field from the bottom right corner (R - 1, C - 1) or to capture both Wboup and Nbslbub in a trap.
 The goal of the trolls in to catch the princess - the princess is considered caught by the trolls if either Wboup or Nbslbub are standing in the same cell as the princess or in a neighboring cell.
 Input

 The first element of the input array will be a string in the format R C, where R and C are the integer the dimensions of the field.
 The second element of the input will be a string in the format Rw Cw;Rn Cn;Rl Cl - pair of coordinates, separated by a ;. Those are the starting coordinates of Wboup, Nbslbub and Lsjtujzbo.
 The rest if the input will contain commands as strings in the following formats:
 "mv unit dir" - you should move unit (Wboup, Nbslbub or Lsjtujzbo) by 1 step in the direction dir.
 "lay trap" - the princess lays a trap on her current location.
 Output

 If one of the trolls catches the princess, output "The trolls caught Lsjtujzbo at", where R and C are the coordinates of the princess.
 If the princess escapes or both trolls fall into a trap, print "Lsjtujzbo is saved! Rw Cw Rn Cn", where Rw Cw are Wboup's coordinates and Rn Cn are Nbslbub's coordinates.
 Constraints

 The directions for moving will always be one of the following: u for up, d for down, l for left, r for right.
 Traps do not stack on top of each other.
 The princess will never start next to the trolls. No two units will start on the same cell.
 The units cannot move out of the field. If a command will take a unit out of the field, don't execute it.
 R will always be between 5 and 30, inclusive.
 C will always be between 2 and 30, inclusive.
 Memory limit: 24MB
 Time limit: 0.3s
 Sample tests

 Sample input 1

 [
 '5 5',
 '1 1;0 1;2 3',
 'mv Lsjtujzbo d',
 'lay trap',
 'mv Lsjtujzbo d',
 'mv Wboup r',
 'mv Wboup r',
 'mv Nbslbub d',
 'mv Nbslbub d',
 'mv Nbslbub d',
 'mv Nbslbub d',
 'mv Nbslbub d',
 'mv Wboup d',
 'mv Wboup d'
 ]
 Sample output 1

 The trolls caught Lsjtujzbo at 4 3
 Sample input 2

 [
 '7 7',
 '0 1;0 2;3 3',
 'mv Lsjtujzbo l',
 'lay trap',
 'mv Lsjtujzbo r',
 'lay trap',
 'mv Lsjtujzbo r',
 'lay trap',
 'mv Lsjtujzbo d',
 'mv Lsjtujzbo r',
 'mv Lsjtujzbo r',
 'mv Lsjtujzbo r',
 'mv Lsjtujzbo r',
 'mv Wboup d',
 'mv Wboup d',
 'mv Wboup l',
 'mv Wboup l',
 'mv Nbslbub r',
 'mv Nbslbub r',
 'mv Nbslbub r',
 'mv Nbslbub d',
 'mv Lsjtujzbo d',
 'mv Lsjtujzbo l',
 'mv Lsjtujzbo l',
 'mv Nbslbub l',
 'mv Nbslbub d',
 'mv Nbslbub d',
 'mv Wboup d',
 'mv Wboup d',
 'mv Wboup r',
 'mv Lsjtujzbo d',
 'mv Wboup d',
 'mv Wboup d',
 'mv Wboup r',
 'mv Lsjtujzbo r',
 'mv Lsjtujzbo r'
 ]
 Sample output 2

 Lsjtujzbo is saved! 6 2 3 4
 Sample input 3

 [
 '8 8',
 '1 3;0 3;5 5',
 'mv Lsjtujzbo l',
 'mv Lsjtujzbo l',
 'lay trap',
 'mv Lsjtujzbo r',
 'lay trap',
 'mv Lsjtujzbo r',
 'lay trap',
 'mv Lsjtujzbo d',
 'lay trap',
 'mv Lsjtujzbo d',
 'lay trap',
 'mv Wboup r',
 'mv Wboup r',
 'mv Wboup d',
 'mv Wboup d',
 'mv Wboup d',
 'mv Wboup d',
 'mv Nbslbub d',
 'mv Nbslbub d',
 'mv Lsjtujzbo l',
 'mv Nbslbub d',
 'mv Nbslbub r',
 'mv Nbslbub r',
 'mv Nbslbub d',
 'mv Nbslbub d',
 'mv Nbslbub d'
 ]
 Sample output 3

 The trolls caught Lsjtujzbo at 7 4

 */

function  solve(args) {
    const CONSTANTS = {
        // Moves constants
        RIGHT : "r",
        LEFT : "l",
        UP : "u",
        DOWN : "d",
        // Names constants
        SVEN_NAME : "Wboup",
        KRISTOFF_NAME : "Nbslbub",
        ANNA_NAME : "Lsjtujzbo"
    };

    // var position = {
    //     row : 0,
    //     col : 0
    // };

    // var pause_menu = {
    //     pause_button : { someProperty : "prop1", someOther : "prop2" },
    //     resume_button : { resumeProp : "prop", resumeProp2 : false },
    //     quit_button : false
    // };


    // function Person(name, age, sex) {
    //     this.name = name;
    //     this.age = age;
    //     this.sex = sex;
    // }
    // and then instantiate two new person objects as follows:
    //
    // var rand = new Person("Rand McKinnon", 33, "M");
    // var ken = new Person("Ken Jones", 39, "M");
    //
    function Hero(myName, name, currPos, isTrol, isInTrap, isCaught, escapedWon) {
        this.myName = myName;
        this.name = name;
        this.currPos = currPos;
        this.isTrol = isTrol;
        this.isInTrap = isInTrap;
        this.isCaught = isCaught;
        this.escapedWon = escapedWon;
    }

    var sven = new Hero("Sven",
        CONSTANTS.SVEN_NAME,
        { row : 0, col : 0 },
        true,
        false,
        false,
        false);

    var kristoff = new Hero("Kristoff",
        CONSTANTS.KRISTOFF_NAME,
        { row : 0, col : 0 },
        true,
        false,
        false,
        false);

    var anna = new Hero("Anna",
        CONSTANTS.ANNA_NAME,
        { row : 0, col : 0 },
        false,
        false,
        false,
        false);

    // var heroes = [
    //     {
    //         myName: "Sven",
    //         name: CONSTANTS.SVEN_NAME,
    //         currPos : { row : 0, col : 0 },
    //         isTrol : true,
    //         isInTrap : false,
    //         isCaught : false,
    //         escapedWon : false
    //
    //     },
    //     {
    //         myName: "Sven",
    //         name: CONSTANTS.SVEN_NAME,
    //         currPos : { row : 0, col : 0 },
    //         isTrol : true,
    //         isInTrap : false,
    //         isCaught : false,
    //         escapedWon : false
    //     },
    //     {
    //         myName: "Anna",
    //         name: CONSTANTS.ANNA_NAME,
    //         currPos : { row : 0, col : 0 },
    //         isTrol : false,
    //         isInTrap : false,
    //         isCaught : false,
    //         escapedWon : false
    //     }
    //
    // ];
    //
    //
    // var sven = {
    //     myName: "Sven",
    //     name: CONSTANTS.SVEN_NAME,
    //     currPos : { row : 0, col : 0 },
    //     isInTrap : false,
    //     isTrol : true
    // };
    //
    // var kristoff = {
    //     myName: "Kristoff",
    //     name: CONSTANTS.KRISTOFF_NAME,
    //     currPos : { row : 0, col : 0 },
    //     isInTrap : false,
    //     isTrol : true
    // };
    //
    // var anna = {
    //     myName: "Anna",
    //     name: CONSTANTS.ANNA_NAME,
    //     currPos : { row : 0, col : 0 },
    //     isCaught : false,
    //     escapedWon : false,
    //     isTrol : false
    // };

    var field = new Array();

    Hero.prototype.move = function (name, direction) {
        if(this.name === name){
            if(this.isTrol && this.isInTrap){
                return;
            }else{
                var row = this.currPos.row;
                var col = this.currPos.col;
                var willBeInside = true;
                var futureRowCol = -1;
                // TODO Commands interpreter
                if(direction === CONSTANTS.RIGHT){
                    futureRowCol = col + 1;

                    willBeInside = (futureRowCol >= 0 && futureRowCol < maxCol);
                    if(willBeInside){
                        this.currPos.col = col + 1;
                    }
                    if (this.name === CONSTANTS.ANNA_NAME){
                        this.currPos.col = col + 1;
                    }

                }else if(direction === CONSTANTS.LEFT){
                    futureRowCol = col - 1;

                    willBeInside = (futureRowCol >= 0 && futureRowCol < maxCol);
                    if(willBeInside){
                        this.currPos.col = col - 1;
                    }
                    if (this.name === CONSTANTS.ANNA_NAME){
                        this.currPos.col = col - 1;
                    }
                }
                else if(direction === CONSTANTS.UP){
                    futureRowCol = row - 1;

                    willBeInside = (futureRowCol >= 0 && futureRowCol < maxRow);
                    if(willBeInside){
                        this.currPos.row = row - 1;
                    }

                    if (this.name === CONSTANTS.ANNA_NAME){
                        this.currPos.row = row - 1;
                    }
                }
                else if(direction === CONSTANTS.DOWN){
                    futureRowCol = row + 1;

                    willBeInside = (futureRowCol >= 0 && futureRowCol < maxRow);
                    if(willBeInside){
                        this.currPos.row = row + 1;
                    }
                    if (this.name === CONSTANTS.ANNA_NAME){
                        this.currPos.row = row + 1;
                    }
                }
            }
        }
    }

    Hero.prototype.layTrap = function (name, command) {

        if(this.isTrol){
            return;
        }else {
            var row = this.currPos.row;
            var col = this.currPos.col;

            field[row][col] = true;
        }
    }

    Hero.prototype.checkIsInTrap = function () {

        if(this.isTrol){
            var row = this.currPos.row;
            var col = this.currPos.col;

            var fieldValue = (field[row][col] === true);
            this.isInTrap = fieldValue;
        }
    }



    function areBothTrolsInSameTrap() {
        var haveSameCoordinates = (sven.currPos.row === kristoff.currPos.row) &&
            (sven.currPos.col === kristoff.currPos.col);
        var areBothInTrp = sven.isInTrap && kristoff.isInTrap;

        if(haveSameCoordinates && areBothInTrp){
            sven.isInTrap = false;
            kristoff.isInTrap = false;
            field[sven.currPos.row][sven.currPos.col] = false;

            return true;
        }else{

            return false;
        }

    }

    //------------------------------------
    // console.log(args);

    // TODO Extract fields dimensions maxRow, maxCol
    var fieldDimensions = args[0].split(" ").map(Number);
    var maxRow = fieldDimensions[0];
    var maxCol = fieldDimensions[1];

    // TODO create field matrix
    // The trolls chase the princess on a field that has R rows and C columns.
    // The field's coordinates are zero-based and are counted up to down, left to right
    // - the first row is 0, the second 1, etc.
    // The first column is 0, the second 1 and so on.
    for(var row = 0; row < maxRow; row += 1){

        var fieldLine = new Array();
        for(var col = 0; col < maxCol; col += 1){

            // Each field value is initially = false, means with no trap layed
            var currFieldValue = false;
            fieldLine.push(currFieldValue);
        }

        field.push(fieldLine);
    }
    // console.log("----------------- Field with initial values")
    // console.log(field);

    // TODO Extract star position of heroes
    var startPositions = ("" + args[1]).split(";");

    // Sven start position
    var startPositionSven = new Array();
    startPositionSven = ("" + startPositions[0]).split(" ").map(Number);
    sven.currPos.row = startPositionSven[0];
    sven.currPos.col = startPositionSven[1];

    // Kristoff start position
    var startPositionKristoff = new Array();
    startPositionKristoff = ("" + startPositions[1]).split(" ").map(Number);
    kristoff.currPos.row = startPositionKristoff[0];
    kristoff.currPos.col = startPositionKristoff[1];

    // Anna start position
    var startPositionAnna = new Array();
    startPositionAnna = ("" + startPositions[2]).split(" ").map(Number);
    anna.currPos.row = startPositionAnna[0];
    anna.currPos.col = startPositionAnna[1];

    // console.log("----------------- Start positions");
    // console.log(anna);
    // console.log(sven);
    //console.log(kristoff);

    // TODO Engine
    for(var argsIx = 2; argsIx < args.length; argsIx += 1){

        // Extract commands and directions from the current input string
        var currInputString = ("" + args[argsIx]).split(" ");
        var currCmd = "" + currInputString[0];
        var currName = "" + currInputString[1];
        var currDir = "" + currInputString[2];

        // console.log("----------------- Current input string cmd and dirs");

        // TODO command move 'mv' or command 'lay'
        if(currCmd === "mv"){
            // Move first
            sven.move(currName, currDir);
            kristoff.move(currName, currDir);
            anna.move(currName, currDir);

            // Check if is in trap
            sven.checkIsInTrap();
            kristoff.checkIsInTrap();

            //Check if both are in trap
            var sameTrp = areBothTrolsInSameTrap();

            var ar = anna.currPos.row;
            var ac = anna.currPos.col;
            var sr = sven.currPos.row;
            var sc = sven.currPos.col;
            var kr = kristoff.currPos.row;
            var kc = kristoff.currPos.col;

            var a = (sr === ar) || (sr + 1 === ar) || (sr - 1 === ar);
            var b = (sc === ac) || (sc + 1 === ac) || (sc - 1 === ac);
            if( a === true && b === true ){
                anna.isCaught = true;
            }

            var c = (kr === ar) || (kr + 1) === ar || (kr - 1 === ar);
            var d = (kc === ac) || (kc + 1) === ac || (kc - 1 === ac);
            if(c && d ){
                anna.isCaught = true;
            }


        }else if(currCmd === "lay"){
            anna.layTrap(currName, currCmd);
        }

        var a = argsIx - 2;
        // console.log("----------------- Current input string cmd and dirs " + a);
        // console.log(field);

        // console.log("sven pos: " + sven.currPos.row + " " + sven.currPos.col);
        // console.log("krist pos: " + kristoff.currPos.row + " " + kristoff.currPos.col);
        // console.log("anna pos: " + anna.currPos.row + " " + anna.currPos.col);


        // TODO End of game checker
        if(anna.currPos.row === -1 && anna.currPos.col === -1){
            anna.escapedWon = true;
        }

        if(anna.isCaught) {
            console.log("The trolls caught Lsjtujzbo at " + anna.currPos.row + " " + anna.currPos.col);
            break;
        }else{

            console.log("Lsjtujzbo is saved! " + sven.currPos.row + " " + sven.currPos.col + " " + kristoff.currPos.row + " " + kristoff.currPos.col);
            break;
        }

    }


}

// var input = [
//     '5 5',
//     '1 1;0 1;2 3',
//     'mv Lsjtujzbo d',
//     'lay trap',
//     'mv Lsjtujzbo d',
//     'mv Wboup r',
//     'mv Wboup r',
//     'mv Nbslbub d',
//     'mv Nbslbub d',
//     'mv Nbslbub d',
//     'mv Nbslbub d',
//     'mv Nbslbub d',
//     'mv Wboup d',
//     'mv Wboup d',
//     'mv Wboup d'
// ];

var input = [
    '7 7',
    '0 1;0 2;3 3',
    'mv Lsjtujzbo l',
    'lay trap',
    'mv Lsjtujzbo r',
    'lay trap',
    'mv Lsjtujzbo r',
    'lay trap',
    'mv Lsjtujzbo d',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup l',
    'mv Wboup l',
    'mv Nbslbub r',
    'mv Nbslbub r',
    'mv Nbslbub r',
    'mv Nbslbub d',
    'mv Lsjtujzbo d',
    'mv Lsjtujzbo l',
    'mv Lsjtujzbo l',
    'mv Nbslbub l',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup r',
    'mv Lsjtujzbo d',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r'
];
solve(input);
