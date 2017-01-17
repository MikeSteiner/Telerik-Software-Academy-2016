import { Pipe, PipeTransform } from '@angular/core';

import { SortEnum } from '../enumerations/sort.enumaration';
import { MoviePropertiesEnum } from '../enumerations/movie-properties.enum';

@Pipe({
    name: 'sortMovies'
})
export class SortMoviesPipe implements PipeTransform {

    constructor(){
    }

    transform(movies: any[], ...args: any[]):any {
        var sort: string = args[0] || '' + SortEnum.Asc,
            orderBy: string = args[1] || MoviePropertiesEnum.Title,
            _sort: number = 1;

        if (movies == null) {
            return null;
        }
        // TODO optimise here
        if(orderBy == '' + MoviePropertiesEnum.Rating){
            orderBy = 'imdbRating';
        }

        if(sort === '' + SortEnum.Asc){
            _sort = 1;
        } else if(sort === '' + SortEnum.Desc){
            _sort = -1;
        } else {
            _sort = 1;
        }

        var sortedMovies = movies;
        sortedMovies.sort(function (a:any, b:any) {
            var aProp:any;
            var bProp:any;

            if(a.hasOwnProperty(orderBy) && b.hasOwnProperty(orderBy) ){
                aProp = a[orderBy];
                bProp = b[orderBy];
            } else {
                aProp = a;
                bProp = b;
            }

            if(aProp > bProp){
                return (1 * _sort);
            } else if (aProp < bProp) {
                return (-1 * _sort);
            } else {
                return 0;
            }
        });

        return sortedMovies;
    }
}

