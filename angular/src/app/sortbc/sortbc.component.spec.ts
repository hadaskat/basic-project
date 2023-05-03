import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SortbcComponent } from './sortbc.component';

describe('SortbcComponent', () => {
  let component: SortbcComponent;
  let fixture: ComponentFixture<SortbcComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SortbcComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SortbcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
