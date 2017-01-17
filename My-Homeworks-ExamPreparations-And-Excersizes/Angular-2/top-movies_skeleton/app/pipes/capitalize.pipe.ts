import { Pipe, PipeTransform } from '@angular/core';

@Pipe({name: 'capitalize'})
export class CapitalizePipe implements PipeTransform {

    transform(values: any[],  times: number):any {

        if (values == null) {
            return null;
        }
        
        var valuesCapitalised = values.map(function(item: any){
            var returnItem = item.toString().charAt(0).toUpperCase() + item.toString().substr(1);

            return returnItem;
        });

        console.log(valuesCapitalised);
        return values;
    }
}

