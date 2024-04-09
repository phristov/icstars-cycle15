import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { Resume } from '../resume.service';

@Component({
  selector: 'app-resume-index',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './resume-index.component.html',
  styleUrl: './resume-index.component.scss'
})
export class ResumeIndexComponent implements OnInit {

  resumes: Resume[] = [];

  constructor(private route: ActivatedRoute) {


  }


  ngOnInit(): void {

    this.route.data.subscribe(x => {
      this.resumes = x['resumes'];
    })

  }
}
