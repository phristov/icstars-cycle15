import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ResumeService {

  constructor(private http: HttpClient) { }


  getAll(): Observable<Resume[]> {
    return this.http.get<Resume[]>('https://localhost:7128/api/Resumes')
  }


  getById(id: number): Observable<Resume> {
    const url = 'https://localhost:7128/api/Resumes/' + id;
    return this.http.get<Resume>(url)
  }
}

export interface Resume {

  resumeId: number;

  personId: number;

  person: Person;


  summary: string

  jobs: Job[]

}

export interface Person {
  personId: number;

  firstName: string;

  lastName: string;

  phoneNumber: string;

  email: string;
}


export interface State {

};

export interface Job {
  jobId: number;

  startDate: string;

  endDate: string

  jobTitle: string;

  jobDescription: string;

  city: string;

  stateId: string;

  state: State

  resumeId: number
  employerName: string;
}
