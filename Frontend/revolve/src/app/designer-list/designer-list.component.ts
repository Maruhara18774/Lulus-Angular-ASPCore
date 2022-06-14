import { Component, OnInit } from '@angular/core';
import { DesignerApi } from '../api/designerApi';
import { Designer } from '../model/Designer';
import { DesignerService } from '../services/designer.service';

@Component({
  selector: 'app-designer-list',
  templateUrl: './designer-list.component.html',
  styleUrls: ['./designer-list.component.css'],
  providers: [DesignerService]
})
export class DesignerListComponent implements OnInit {
  baseURL: String = "http://localhost:4200";
  keywordLs: String[] = new Array<String>("#","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z");
  designerLsByKeyword: Designer[][] = new Array<Designer[]>();
  designerLs: Designer[] = new Array<Designer>();
  lsLength: number[] = new Array<number>();
  isAll: boolean = true;
  currentIndex: number;
  currentDesignerLs: Designer[] = new Array<Designer>();

  constructor(private designerService: DesignerService) { }

  ngOnInit(): void {
    this.loadDesigner();
  }

  async loadDesigner(){
    var api = new DesignerApi();
    var result = await api.getAll();
    if (result.status === 200) {
      this.designerLs = this.designerService.convertJSONtoListDesigner(result.body);
      this.createArrDesignerByKeyword();
      for(var i = 1; i<this.designerLs.length;i++){
        this.lsLength.push(i);
      }
    }
    else {
      console.log('Error: ' + result.body);
    }
  }
  createArrDesignerByKeyword(){
    this.designerLsByKeyword = new Array<Designer[]>();
    for(var i = 0; i<this.keywordLs.length;i++){
      var item = this.keywordLs[i];
      if(item == "#"){
        this.designerLsByKeyword[i] = this.designerLs;
      }
      else{
        this.designerLsByKeyword[i] = this.designerLs.filter(word => word.name.startsWith(item.toString()));
      }
    }
  }
  setCurrentKeyword(keyword: String){
    if(keyword == "#"){
      this.isAll = true;
    }
    else{
      this.isAll = false;
      this.currentIndex = this.keywordLs.findIndex((element) => element == keyword);
    }
  }
}
