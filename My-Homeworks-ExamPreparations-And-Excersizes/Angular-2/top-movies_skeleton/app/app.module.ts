import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms'

import { AppComponent } from './app.component';
import { MovieListComponent } from './components/movie-list.component';
import { MovieBoxComponent } from './components/movie-box.component';

import { CapitalizePipe } from './pipes/capitalize.pipe';
import { SortMoviesPipe } from './pipes/sort-movies.pipe';
import { FilterMoviesPipe } from "./pipes/filter-movies.pipe";

import { MovieService } from './services/movie.service';

@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        FormsModule
    ],
    declarations: [
        AppComponent,

        CapitalizePipe,
        MovieListComponent,
        SortMoviesPipe,
        FilterMoviesPipe,
        MovieBoxComponent
    ],
    providers: [MovieService],
    bootstrap: [ AppComponent ]
})
export class AppModule { }
