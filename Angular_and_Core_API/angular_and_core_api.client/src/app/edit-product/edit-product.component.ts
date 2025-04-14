import { Component } from '@angular/core';
import { SerAllService } from '../ser-all.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-product',
  templateUrl: './edit-product.component.html',
  styleUrl: './edit-product.component.css'
})
export class EditProductComponent {


  Product_Id: any;
  constructor(private _ser: SerAllService, private _act: ActivatedRoute) { }




  Edit_Product(data: any) {

    this.Product_Id = this._act.snapshot.paramMap.get("id");

    this._ser.EditProduct(data, this.Product_Id).subscribe(() => {

      alert("Edit data is successfully");

    })

  }



}
