/**
 * Created by Admin on 4.7.2016 г..
 */
/*
 Problem 2 – Labyrinth Escape
 You are given a rectangular field of size NxM, filled with numbers and directions. On each cell on the field there will be a direction marked with the letters l, r, u, d.
 By given position (R, C) (Rth row and Cth column) the directions are as follows:
 From (R, C) go l => (R, C-1)
 From (R, C) go r => (R, C+1)
 From (R, C) go u => (R-1, C)
 From (R, C) go d => (R+1, C)
 The numbers in the field are always as follows:
 On the first row the values are from 1 to M, on the second row – from M+1 to 2*M, on the third row – from 2*M +1 to 3*M, on the Nth row – from (N-1)*M to N*M.
 By given start position, find the path outside of the field, or print if you are lost.
 Example:
 N = 3
 M = 4
 Start position: 1 3
 Input
 The method Solve accepts a zero-based array of strings. The arguments are as follows:
 args[0] contains M and N separated by a single space (" ")
 args[1] contains R and C – the start position (the star position is zero-based)
 args[2] to args[N+2] contain exactly M characters(only the letters 'l', 'r', 'u' or 'd')
 Output
 The output data should be printed on the console.
 The output should contain a single string – "out SUM_OF_NUMBERS_IN_THE_PATH" or "lost NUMBER_OF_CELL_IN_THE_PATH"
 "out SUM_OF_NUMBERS_IN_THE_PATH" means the at some point you can go outside of the field
 "lost NUMBER_OF_CELL_IN_THE_PATH" means that you are stepping on a cell that is already visited
 Constraints
 •	N and M will be always between 1 and 500
 •	Allowed working time for your program: 0.2 seconds. Allowed memory: 16 MB.
 Examples
 Input example	Output example
 args =[
 "3 4",
 "1 3",
 "lrrd",
 "dlll",
 "rddd"]	out 45
 args =[
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "durlddud",
 "urrrldud",
 "ulllllll"]	lost 21
 args =[
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "lurlddud",
 "urrrldud",
 "ulllllll"]	out 442
 */

function  solve(args) {
    const CONSTANTS = {
        RIGHT : "r",
        LEFT : "l",
        UP : "u",
        DOWN : "d"
    };
    var moves = new Array();
    var numbers = new Array();
    var bestSum = 0;
    var summedCellsCounter = 0;

    function calculateStartRowValue(currentRow, maxCol) {
        // The numbers in the field are always as follows:
        // On the
        // first row the values are from 1 to M, on the
        // second row – from M+1 to 2*M, on the
        // third row – from 2*M +1 to 3*M, on the
        // Nth row – from (N-1)*M to N*M.
        var result = (maxCol * currentRow) + 1;

        return parseInt(result);
    }
    
    // console.log(args);

    // TODO Fill out rowsCount and colsCount count
    // You are given a rectangular field of size NxM
    var dimensions = args[0].split(" ").map(Number);
    var rowsCount = dimensions[0];
    var colsCount = dimensions[1];

    // TODO Fill start position
    // You are given a rectangular field of size NxM
    var startPosition = args[1].split(" ").map(Number);
    var startRow = startPosition[0];
    var startCol = startPosition[1];

    // TODO Fill out moves array
    for(var l = 2; l < args.length; l += 1){
        var lineCmds = args[l].split("").map(String);
        moves.push(lineCmds);
    }
    // console.log(moves);

    // TODO Fill out numbers array
    for(var row = 0; row < rowsCount; row += 1){
        var lineNums = new Array();
        // TODO calculate the start row value
        // The numbers in the field are always as follows:
        // On the
        // first row the values are from 1 to M, on the
        // second row – from M+1 to 2*M, on the
        // third row – from 2*M +1 to 3*M, on the
        // Nth row – from (N-1)*M to N*M.
        var startRowValue = calculateStartRowValue(row, colsCount);

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
    // console.log(numbers);


    // TODO Main processor
    // You start always at position (0, 0) – row = 0, column = 0.
    var row = startRow;
    var col = startCol;
    var currCellValue = 1001;
    var currCommand = "";

    while(true){
        // TODO Check if inside the matrix
        var isInside = (row >= 0 && row < rowsCount) && (col >= 0 && col < colsCount);
        if(!isInside){
            // TODO print exit with succseded
            //  The output should contain a single string – "out SUM_OF_NUMBERS_IN_THE_PATH"
            // "out SUM_OF_NUMBERS_IN_THE_PATH" means the at some point you can go outside of the field
            console.log("out " + bestSum);
            break;
        }

        // TODO Read current cell value
        currCellValue = numbers[row][col];

        var isFail = (currCellValue === null);
        if(isFail){
            // TODO print exit with failed
            //  The output should contain a single string – "lost NUMBER_OF_CELL_IN_THE_PATH"
            // "lost NUMBER_OF_CELL_IN_THE_PATH" means that you are stepping on a cell that is already visited
            console.log("lost " + summedCellsCounter );
            break;
        }

        // TODO increase best sum and remove the cell content
        bestSum += currCellValue;
        // Increment summed cells counter
        summedCellsCounter += 1;
        // Put cell value to null
        numbers[row][col] = null;

        // TODO Move to the next cell
        currCommand = "" + moves[row][col];
        // TODO Commands interpreter
        if(currCommand === CONSTANTS.RIGHT){
            col = col + 1
        }else if(currCommand === CONSTANTS.LEFT){
            col = col - 1;
        }
        else if(currCommand === CONSTANTS.UP){
            row = row - 1;
        }
        else if(currCommand === CONSTANTS.DOWN){
            row = row + 1;
        }

    }
}

// var input = [
//     '3 4',
//     '1 3',
//     'lrrd',
//     'dlll',
//     'rddd' ];
// var input = [
//     '5 8',
//     '0 0',
//     'rrrrrrrd',
//     'rludulrd',
//     'durlddud',
//     'urrrldud',
//     'ulllllll' ];
var input = [
    '5 8',
    '0 0',
    'rrrrrrrd',
    'rludulrd',
    'lurlddud',
    'urrrldud',
    'ulllllll' ];
solve(input);


