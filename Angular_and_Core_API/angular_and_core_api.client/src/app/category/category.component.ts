import { Component } from '@angular/core';
import { SerAllService } from '../ser-all.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})
export class CategoryComponent {


  constructor(private _ser: SerAllService) { }


  AllData: any

  ngOnInit() {

    this.getAllCategory()
  }


  getAllCategory() {

    this._ser.GetCategory().subscribe(data => {


      this.AllData = data;


    })

  }

}
