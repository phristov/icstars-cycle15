import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Resume } from '../resume.service';
import { JsonPipe } from '@angular/common';

@Component({
  selector: 'app-resume-detail',
  standalone: true,
  imports: [JsonPipe],
  templateUrl: './resume-detail.component.html',
  styleUrl: './resume-detail.component.scss'
})
export class ResumeDetailComponent {

  resume: Resume | any;

  constructor(private route: ActivatedRoute) {

    this.resume = {};
  }


  ngOnInit(): void {

    this.route.data.subscribe(x => {
      this.resume = x['resume'];
      console.log(this.resume);
    })

  }
}
