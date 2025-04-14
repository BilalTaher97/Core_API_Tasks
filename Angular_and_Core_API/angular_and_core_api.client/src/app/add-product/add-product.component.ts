import { Component } from '@angular/core';
import { SerAllService } from '../ser-all.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.css'
})
export class AddProductComponent {


  constructor(private _ser: SerAllService) { }



  Add_Product(data:any) {


    this._ser.AddProduct(data).subscribe(() => {

      alert("Data added successfully!");

    })


  }


}
