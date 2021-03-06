import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  
  title = 'ProductList';

  productsList:any = [];

  constructor(private httpClient: HttpClient) {
  }

  ngOnInit(): void {
    try {
      // fetch data from productlist backend service
      this.httpClient.get<any>('http://127.0.0.1:5000/productlist').subscribe({
        next: data => {
          this.productsList = data;
        },
        error: error => {
          console.error(error);
        }
      });
    }
    catch (error) {
      console.log(error);
    }
  }
}