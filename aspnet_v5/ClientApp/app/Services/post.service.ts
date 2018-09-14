import { Injectable } from '@angular/core';
import { Http } from '@angular/http';


// den skal angives som provider - se app.module.shared
@Injectable()

    export class PostService {

        constructor(private http: Http) { }

        getPosts() {
            return this.http.get('/api/posts');
        }
    }



