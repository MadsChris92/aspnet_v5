import { Component } from '@angular/core';

@Component({
    selector: 'post',
    templateUrl: './post.component.html'
})
export class PostComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
