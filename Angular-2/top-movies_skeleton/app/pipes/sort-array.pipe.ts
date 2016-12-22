import { Pipe, PipeTransform } from '@angular/core';

import { SortEnum } from '../enumerations/sort.enumaration';

@Pipe({name: 'sortArray'})
export class SortArrayPipe implements PipeTransform {

    constructor(){
    }

    transform(arrayToSort: any[], ...args: any[]):any {
        var sort: string = args[0] || '' + SortEnum.Asc,
            _sort: number = 1;

        if (arrayToSort == null) {
            return null;
        }

        if(sort === '' + SortEnum.Asc){
            _sort = 1;
        } else if(sort === '' + SortEnum.Desc){
            _sort = -1;
        } else {
            _sort = 1;
        }

        var sortedArray = arrayToSort;
        sortedArray.sort(function (a:any, b:any) {
            if(a > b){
                return (1 * _sort);
            } else if (a < b) {
                return (-1 * _sort);
            } else {
                return 0;
            }
        });

        return sortedArray;
    }
}

