/**
 * Created by Admin on 29.6.2016 г..
 */

function GetMax(params) {
    params = params[0].split(' ');
    return Math.max(+params[0], +params[1], +params[2]);
}