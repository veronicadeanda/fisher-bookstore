import { Component, OnInit } from '@angular/core';
import { Book } from '../book';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {

  books: Book[] = [ 
    {
      id: 1,
      title: 'Ready Player One',
      author: 'Ernest Cline'
    },
    {
      id: 2,
      title: "Catch 22",
      author: "Joseph Heller"
    }
  ];

  constructor() { }

  ngOnInit() {
  }

}
