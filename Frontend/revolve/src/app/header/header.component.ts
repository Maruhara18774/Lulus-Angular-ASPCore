import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  providers: [UserService]
})
export class HeaderComponent implements OnInit {
  token:String = '';
  @Output() featureSelected = new EventEmitter<string>(); 
  constructor(private userService: UserService,private route: ActivatedRoute,) {
   }

  
  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.token = this.userService.getToken();
  });
  }
}
