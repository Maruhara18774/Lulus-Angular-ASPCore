import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FavorProductComponent } from './favor-product.component';

describe('FavorProductComponent', () => {
  let component: FavorProductComponent;
  let fixture: ComponentFixture<FavorProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FavorProductComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FavorProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
