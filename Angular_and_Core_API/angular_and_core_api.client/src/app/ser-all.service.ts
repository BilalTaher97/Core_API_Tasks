import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SerAllService {

  constructor(private _GetUrl: HttpClient) { }



  GetCategory() {

    return this._GetUrl.get("https://localhost:7158/api/Category/Category")

  }

  GetProduct() {

    return this._GetUrl.get("https://localhost:7158/Product")

  }

  GetProductByID(id : any) {

    return this._GetUrl.get(`https://localhost:7158/GetProductByID?id=${id}`)

  }

  AddCategory(data:any) {

    return this._GetUrl.post<any>("https://localhost:7158/api/Category/AddCategory", data)

  }


  AddProduct(data: any) {

    return this._GetUrl.post<any>("https://localhost:7158/AddProduct", data)

  }

  EditProduct(data: any,id:any) {

    return this._GetUrl.put<any>(`https://localhost:7158/EditProduct/${id}`, data)

  }

  DeleteProduct(id: any) {

    return this._GetUrl.delete<any>(`https://localhost:7158/DeleteProduct/${id}`)

  }
}
