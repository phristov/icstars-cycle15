import { TestBed } from '@angular/core/testing';
import { ResolveFn } from '@angular/router';

import { resumeResolver } from './resume.resolver';

describe('resumeResolver', () => {
  const executeResolver: ResolveFn<boolean> = (...resolverParameters) => 
      TestBed.runInInjectionContext(() => resumeResolver(...resolverParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeResolver).toBeTruthy();
  });
});
