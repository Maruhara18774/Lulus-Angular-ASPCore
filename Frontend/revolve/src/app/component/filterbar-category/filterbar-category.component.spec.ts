import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FilterbarCategoryComponent } from './filterbar-category.component';

describe('FilterbarCategoryComponent', () => {
  let component: FilterbarCategoryComponent;
  let fixture: ComponentFixture<FilterbarCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FilterbarCategoryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FilterbarCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
