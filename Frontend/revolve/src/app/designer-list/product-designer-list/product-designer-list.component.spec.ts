import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductDesignerListComponent } from './product-designer-list.component';

describe('ProductDesignerListComponent', () => {
  let component: ProductDesignerListComponent;
  let fixture: ComponentFixture<ProductDesignerListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductDesignerListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductDesignerListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
