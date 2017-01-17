import { Component, Inject, OnInit } from '@angular/core';

import { Movie } from "../models/movie.model";
import { MovieService } from '../services/movie.service';
import { SortEnum } from '../enumerations/sort.enumaration';
import { MoviePropertiesEnum } from '../enumerations/movie-properties.enum';

@Component({
    selector: 'movie-list',
    providers: [ MovieService ],
    templateUrl: 'movie-list.component.html',
    styles: [`
		body{
			font-family: Arial, Helvetica, sans-serif;			
			margin: 0;
			padding: 0;
		}
		
		.bg-lightgrey {
            background-color: lightgrey;
        }
        
        .container-fluid-override{
          height: 100%;
        }
        
        .row-first {
            line-height: 200%;
            overflow: hidden;
        }
		
		.poster-size{
			width: 50%;
			heigth: 100%;
		}		
	`]
})
export class MovieListComponent implements OnInit {
    movieService: MovieService;

    movies: Movie[];

    filter: string;
    sortOptions: string[];
    orderByOptions: string[];
    sortOption: string;
    orderByOption: string;

    constructor(@Inject(MovieService) _movieService: MovieService){
        this.movieService = _movieService;
        this.movies = [];

        this.filter = '';
        this.sortOptions = this.getEnumValues(<any>SortEnum);
        this.orderByOptions = this.getEnumValues(<any>MoviePropertiesEnum);
        this.sortOption = '' + SortEnum.Asc;
        this.orderByOption = '' + MoviePropertiesEnum.Title;
        // ***********************************************
        // Web Storm bug
        // ***********************************************
        // using the toString() funtion is not recognised it is a bug in WebStorm
        // use only if you need the error checks for null and undefined
        // in that particular case the Enum value is fixed to string

        // this.defaultSort = SortEnum.Asc.toString();
        // ***********************************************
    }

    private getEnumValues(enumObject: any[]):any[]{
        var arrayToReturn: any[];
        arrayToReturn = [];

        for(var element in enumObject){
            arrayToReturn.push(element);
        }

        return arrayToReturn;
    }

    ngOnInit(){
        this.movieService.getMovies()
            .subscribe(
                movies => {
                    this.movies = movies;
                }, //Bind to view
                err => {
                    // Log errors if any
                    console.log(err);
            });
    }
}

