import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCategoryComponent } from './add-category/add-category.component';
import { ProductComponent } from './product/product.component';
import { ShowDetailsComponent } from './show-details/show-details.component';
import { AddProductComponent } from './add-product/add-product.component';
import { EditProductComponent } from './edit-product/edit-product.component';

const routes: Routes = [

  { path: "AddCategory", component: AddCategoryComponent },
  { path: "getAllProduct", component: ProductComponent },
  { path: "ShowDetails/:id", component: ShowDetailsComponent },
  { path: "AddProduct", component: AddProductComponent },
  { path: "EditProduct/:id", component: EditProductComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
