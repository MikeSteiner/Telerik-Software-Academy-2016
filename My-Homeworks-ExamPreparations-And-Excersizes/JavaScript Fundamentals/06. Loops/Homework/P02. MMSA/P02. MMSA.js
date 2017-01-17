function solve(params) {
    var min = +params[0];
    var max = +params[0];
    var sum = 0;
    var avarage = 0;
    
    for (var i = 0; i < params.length; i++) {
        var element = +params[i];
        if (element > max) {
            max = element;
        }

        if (element < min) {
            min = element;
        }

        sum+=element;
    }
    avarage = sum / params.length;
    console.log('min='+min.toFixed(2));
    console.log('max='+max.toFixed(2));
    console.log('sum='+sum.toFixed(2));
    console.log('avg='+avarage.toFixed(2));
}