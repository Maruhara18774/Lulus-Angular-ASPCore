import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CategoryApi } from '../api/categoryApi';
import { Category } from '../model/Category';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent implements OnInit {
  cateList:Category[] = new Array<Category>();

  constructor(private route: ActivatedRoute,private router: Router) { }

  ngOnInit(): void {
    this.loadCategory();
  }
  async loadCategory(){
    var api = new CategoryApi();
    var result = await api.getAll();
    if(result.status === 200){
      console.log('Success: ' + result.body);
      for(let i = 0;i<result.body.length;i++){
        const cate = new Category(parseInt(result.body[i].id), result.body[i].name);
        this.cateList.push(cate);
      }
    }
    else{
      console.log('Error: ' + result.body);
    }
  }

  goToProductList(id: number){
    this.router.navigate(['/clothing-list/'+id], {relativeTo: this.route});
  }

}
