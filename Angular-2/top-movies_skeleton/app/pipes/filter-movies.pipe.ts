import { Pipe, PipeTransform } from '@angular/core';

import { MoviePropertiesEnum } from '../enumerations/movie-properties.enum';

@Pipe({
    name: 'filterMovies'
})
export class FilterMoviesPipe implements PipeTransform {

    constructor(){}

    transform(movies: any[], ...args: any[]):any {
        var filter: string = args[0] || '',
            filterProperty: string = args[1] || '' + MoviePropertiesEnum.Title;

        if (movies == null) {
            return null;
        }

        var filteredMovies = movies.filter(function (item:any) {
            var itemProp: any;

            if (item.hasOwnProperty(filterProperty)) {
                itemProp = item[filterProperty];
            } else {
                itemProp = MoviePropertiesEnum.Title;
            }

            var isContained =  (itemProp.indexOf(filter) >= 0);
            if(isContained){
                return item;
            }

        });

        return filteredMovies;
    }
}