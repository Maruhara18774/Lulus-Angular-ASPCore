import { Component, OnInit } from '@angular/core';
import { CategoryApi } from 'src/app/api/categoryApi';
import { Category } from 'src/app/model/Category';

@Component({
  selector: 'app-filterbar-category',
  templateUrl: './filterbar-category.component.html',
  styleUrls: ['./filterbar-category.component.css']
})
export class FilterbarCategoryComponent implements OnInit {
  baseURL: String = "http://localhost:4200";
  cateList: Category[] = new Array<Category>();

  constructor() { }

  ngOnInit(): void {
    this.loadCategory();
  }

  async loadCategory() {
    var api = new CategoryApi();
    var result = await api.getAll();
    if (result.status === 200) {
      for (let i = 0; i < result.body.length; i++) {
        const cate = new Category(parseInt(result.body[i].id), result.body[i].name);
        this.cateList.push(cate);
      }
    }
    else {
      console.log('Error: ' + result.body);
    }
  }
}
