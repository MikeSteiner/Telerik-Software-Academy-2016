/**
 * Created by admin on 16.12.2016 г..
 */
// Imports
import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

// Import RxJx required methods
// import 'rxjs/add/operator/map';
// import 'rxjs/add/operator/catch';

import {} from '../models/movie.model';
import {Observable} from "rxjs";
import {Movie} from "../models/movie.model";

@Injectable()
export class MovieService{
    public static PATH: string = '../data/movies.json';

    constructor(private http: Http){}

    // Get all movies
    getMovies(): Observable<Movie[]>{
        var moviesToReturn: Observable<Movie[]>;

        moviesToReturn = this.http.get(MovieService.PATH)
            // ...and calling .json() on the response to return data
            .map((res:Response) => res.json())
            //...errors if any
            .catch((error:any) => Observable.throw(error.json().error || 'Server error'));

        return moviesToReturn;
    }
}