function solve(params) {
    var num = +params[0];
    var row = '';

    for (var i = 1; i <= num; i++) {
        for (var j = i; j <= num + (i-1); j++) {
            row+=j+' ';
        }
        console.log(row);
        row ='';
    }

}