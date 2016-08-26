/**
 * Created by Admin on 4.7.2016 г..
 */
/*
 Problem 2 – Paths
 You are given a matrix of directions. The rows are zero-based. The possible directions are four:
 •	"dr" stands for "down-right" direction
 •	"ur" stands for "up-right" direction
 •	"ul" stands for "up-left" direction
 •	"dl" stands for "down-left" direction
 You should generate another matrix with the same size. The numbers in each row are consecutive. The leftmost (first) number in each row is a power of 2, calculated with the formula 2row where row is the number of this row.
 Your task is to find the sum that can be found, using the given directions and summing the numbers in each cell you step into. If with the current direction, you step out of the matrix – print "successed with SUM", where sum is the calculated sum. If you step on a cell, that you have previously stepped in – print "failed at POSITION", where POSITION is the position of the previously visited cell.
 You start always at position (0, 0) – row = 0, column = 0.
 Create a function in JavaScript that solves this problem.
 Example:
 The sum is 20, the output should be: "successed with 20"







 Stepped on a visited cell with coordinates (1, 1), the output should be: "failed at (1, 1)"








 Input
 The first value of the input arguments you will be the numbers R and C, separated by a space
 •	R is the number of rows in the matrix
 •	C is the number of columns in the matrix
 The next R values in the input arguments will be exactly C directions, separated by a space
 Output
 Your function should return a single string:
 •	If success, return "successed with SUM", where sum is the sum of the visited cells
 •	If fail, return "failed at POSITION", where POSITION is the position of the already visited cell
 Constraints
 •	N will be between 2 and 30, inclusive
 •	C will be between 2 and 1000, inclusive
 •	Allowed working time for your program: 0.1 seconds.
 •	Allowed memory: 16 MB.
 Examples
 Input	Output	Explanation
 args =[
 '3 5',
 'dr dl dr ur ul',
 'dr dr ul ur ur',
 'dl dr ur dl ur'
 ]
 successed with 20	Explained in the example above

 Input	Output	Explanation
 args = [
 '3 5',
 'dr dl dl ur ul',
 'dr dr ul ul ur',
 'dl dr ur dl ur'
 ]	failed at (1, 1)	Explained in the example above

 */
function  solve(args) {
    const CONSTANTS = {
        // "dr" stands for "down-right" direction
        // "ur" stands for "up-right" direction
        // "ul" stands for "up-left" direction
        // "dl" stands for "down-left" direction
        DOWN_RIGHT : "dr",
        UP_RIGHT : "ur",
        UP_LEFT : "ul",
        DOWN_LEFT : "dl"
    };
    var moves = new Array();
    var numbers = new Array();
    var bestSum = 0;

    function calculateStartRowValue(rowNumber) {
        //  The numbers in each row are consecutive.
        //  The leftmost (first) number in each row is a power of 2,
        //  calculated with the formula 2row where row is the number of this row.
        var result = 1;
        // If row is the zeroth row => 2 on power 0 = 1
        if(rowNumber === 0){
            return 1;
        }
        // If row is more than 0 row => 2 on power row: 2, 4, 8, 16...
        for(var i = 0; i < rowsCount; i += 1){
            result *= 2;
        }

        return parseInt(result);
    }

    // console.log(args);
    // TODO Fill out rowsCount and Cols count
    // The first value of the input arguments you will be the numbers R and C, separated by a space
    // R is the number of rows in the matrix
    // C is the number of columns in the matrix
    var dimensions = args[0].split(" ").map(Number);
    var rowsCount = dimensions[0];
    var colsCount = dimensions[1];

    // TODO Fill out moves array
    for(var l = 1; l < args.length; l += 1){
        var lineCmds = args[l].split(" ").map(String);
        moves.push(lineCmds);
    }
    // console.log(moves);

    // TODO Fill out numbers array
    for(var row = 0; row < rowsCount; row += 1){
        var lineNums = new Array();
        // TODO calculate the start row value
        //  The leftmost (first) number in each row is a power of 2,
        //  calculated with the formula 2row where row is the number of this row.
        var startRowValue = calculateStartRowValue(row);

        for(var col = 0; col < colsCount; col += 1){
            // TODO create the numbers line with the power of '2'...
            //  The numbers in each row are consecutive.
            //  The leftmost (first) number in each row is a power of 2,
            //  calculated with the formula 2row where row is the number of this row.
            var currValueToFill = startRowValue + col;
            lineNums.push(currValueToFill);
        }

        numbers.push(lineNums);
    }
    // console.log(lineNums);


    // TODO Main processor
    // You start always at position (0, 0) – row = 0, column = 0.
    var row = 0;
    var col = 0;
    var currCellValue = 1001;
    var currCommand = "";

    while(true){
        // TODO Check if inside the matrix
        var isInside = (row >= 0 && row < rowsCount) && (col >= 0 && col < colsCount);
        if(!isInside){
            // TODO print exit with succseded
            //  If with the current direction, you step out of the matrix –
            //  print "successed with SUM", where sum is the calculated sum
            console.log("successed with " + bestSum);
            break;
        }

        // TODO Read current cell value
        currCellValue = numbers[row][col];

        var isFail = (currCellValue === null);
        if(isFail){
            // TODO print exit with failed
            //  If you step on a cell, that you have previously stepped in –
            //  print "failed at POSITION", where POSITION is the position of the previously visited cell.
            console.log("failed at (" + row + ", " + col + ")");
            break;
        }

        // TODO increase best sum and remove the cell content
        bestSum += currCellValue;
        // Put cell value to null
        numbers[row][col] = null;

        // TODO Move to the next cell
        currCommand = "" + moves[row][col];
        // TODO Commands interpreter
        if(currCommand === CONSTANTS.DOWN_RIGHT){
            row = row + 1;
            col = col + 1
        }else if(currCommand === CONSTANTS.DOWN_LEFT){
            row = row + 1;
            col = col - 1;
        }
        else if(currCommand === CONSTANTS.UP_RIGHT){
            row = row - 1;
            col = col + 1;
        }
        else if(currCommand === CONSTANTS.UP_LEFT){
            row = row - 1;
            col = col - 1;
        }

    }
}

//3 5,dr ur dr ul dr,dr ur dr dl dr,dr ur dr ul dr

var input = [
    '3 5',
    'dr dl dr ur ul',
    'dr dr ul ur ur',
    'dl dr ur dl ur'
];
// var input = [
//     '3 5',
//     'dr dl dl ur ul',
//     'dr dr ul ul ur',
//     'dl dr ur dl ur'
// ];

solve(input);


