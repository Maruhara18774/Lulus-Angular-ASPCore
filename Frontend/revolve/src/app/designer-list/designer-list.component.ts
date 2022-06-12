import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-designer-list',
  templateUrl: './designer-list.component.html',
  styleUrls: ['./designer-list.component.css']
})
export class DesignerListComponent implements OnInit {
  keywordLs: String[] = new Array<String>("#","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z");
  constructor() { }

  ngOnInit(): void {
  }
}
