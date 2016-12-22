import { Component, Input } from '@angular/core';

import { Movie } from "../models/movie.model";

@Component({
    selector: 'movie-box',
    templateUrl: 'movie-box.component.html',
    styles: [`
		.poster-size{
			width: 80%;
			heigth: 100%;
		}	
			
		.top-border{
		    border-top: 1px solid black;
		}
		
		.container-fluid-override{
            padding: auto;
            margin: auto;
            padding-top: 1%;
            padding-bottom: 1%;
            border-top: 1px solid black;
        }
	`]
})
export class MovieBoxComponent {
    @Input() movie: Movie;
}