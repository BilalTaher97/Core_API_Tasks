import { Component } from '@angular/core';
import { SerAllService } from '../ser-all.service';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrl: './add-category.component.css'
})
export class AddCategoryComponent {


  constructor(private _ser: SerAllService) { }



  Add_Category(data: any) {

    


    this._ser.AddCategory(data).subscribe(() =>{

      alert("Data added successfully!");
       
    })
  }

}
