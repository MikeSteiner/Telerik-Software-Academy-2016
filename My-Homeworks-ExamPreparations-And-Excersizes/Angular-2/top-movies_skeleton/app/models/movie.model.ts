export class Movie{
    constructor(
        public Title: string,
        public Year: number,
        public Released: Date,
        public Poster: string,
        public imdbRating: number
    ){}
}