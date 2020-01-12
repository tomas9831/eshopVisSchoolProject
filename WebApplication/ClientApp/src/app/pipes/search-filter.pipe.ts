import { Pipe, PipeTransform } from '@angular/core';
import { IProduct } from '../product-list/product';
import { isNgTemplate } from '@angular/compiler';
import { filter } from 'minimatch';
import { Game } from '../_models/game';

@Pipe({
  name: 'searchFilter'
})
export class SearchFilterPipe implements PipeTransform {
  transform(products: Game[], filterText: string): Game[] {
    if (!products) {
      return [];
    }
    if (!filterText) {
      return products;
    }
    filterText = filterText.toLowerCase();
    const filteredProducts: Game[] = new Array();
    products.forEach(product => {
      const productName = product.name.toLowerCase();
      if (productName.includes(filterText)) {
        filteredProducts.push(product as Game);
      }
    });
    return filteredProducts;
  }
}
