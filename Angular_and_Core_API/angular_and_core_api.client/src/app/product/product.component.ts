import { Component } from '@angular/core';
import { SerAllService } from '../ser-all.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {


  AllProduct: any


  constructor(private _ser: SerAllService) { }


  ngOnInit() {
    this.GetAllData();
  }


  GetAllData() {

    this._ser.GetProduct().subscribe(data => {

      this.AllProduct = data;
      console.log(`ttttttttttttttttttt ${this.AllProduct}`)
    })

  }

  DeleteProduct(id: any) {

    this._ser.DeleteProduct(id).subscribe(() => {
      this.GetAllData();
    })

  }

}
