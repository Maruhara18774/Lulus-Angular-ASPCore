import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FilterbarProductComponent } from './filterbar-product.component';

describe('FilterbarProductComponent', () => {
  let component: FilterbarProductComponent;
  let fixture: ComponentFixture<FilterbarProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FilterbarProductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FilterbarProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
