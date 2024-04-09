import { Routes } from '@angular/router';
import { ResumeIndexComponent } from './resume-index/resume-index.component';
import { ResumeDetailComponent } from './resume-detail/resume-detail.component';
import { resumeByIdResolver, resumesResolver } from './resume.resolver';

export const routes: Routes = [{
    path: 'resumes',
    component: ResumeIndexComponent,
    resolve: { resumes: resumesResolver }
}, {
    path: 'resumes/:id',
    component: ResumeDetailComponent,
    resolve: { resume: resumeByIdResolver }
}
];
