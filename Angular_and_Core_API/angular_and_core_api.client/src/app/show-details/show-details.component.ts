import { Component } from '@angular/core';
import { SerAllService } from '../ser-all.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-show-details',
  templateUrl: './show-details.component.html',
  styleUrl: './show-details.component.css'
})
export class ShowDetailsComponent {

  Pro_Id: any
  Product: any
  constructor(private _url: SerAllService, private _Act: ActivatedRoute) { }


  ngOnInit() {
    this.Pro_Id = this._Act.snapshot.paramMap.get('id');

    this.getProduct()

  }


  getProduct() {

    this._url.GetProductByID(this.Pro_Id).subscribe(data => {

      this.Product = data;

    })


  }

}
