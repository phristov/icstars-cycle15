import { inject } from '@angular/core';
import { ResolveFn } from '@angular/router';
import { Resume, ResumeService } from './resume.service';
import { Observable } from 'rxjs';

export const resumesResolver: ResolveFn<Observable<Resume[]>> = (route, state) => {
  return inject(ResumeService).getAll();
};

export const resumeByIdResolver: ResolveFn<Resume> = (route, state) => {
  const id = Number(route.paramMap.get('id'));
  return inject(ResumeService).getById(id);
};
