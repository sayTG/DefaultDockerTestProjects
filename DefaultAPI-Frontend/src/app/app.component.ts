import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(private http: HttpClient) {}

  URL = '';
  response = '';
  title = '';
  base = '';

  ngOnInit(): void {
    this.URL = `${environment.BASE_URL}/api/values/get`;
    this.title = 'DefaultAPI-Frontend';
    this.base = environment.BASE_URL;
  }
  fetchRequest() {
    this.http.get(this.URL).subscribe({
      next: (res: any) => {
        this.response = JSON.stringify(res);
      },
    });
  }
}