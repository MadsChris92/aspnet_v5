import { Component } from '@angular/core';

import { PostService } from './../../Services/post.service';


@Component({
    selector: 'post',
    templateUrl: './post.component.html'
})
export class PostComponent {
    posts: any;
    constructor(private postService: PostService) {}

    ngOnInit() {
        this.postService.getPosts().subscribe(posts => this.posts = posts);

        console.log(this.posts);
    }
}
