import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'availableOnly'
})
export class AvailableOnlyPipe implements PipeTransform {

  transform(items: any, ...args: any[]): any {
    if (items) {
      return items.filter(t => t.available);
    }
  }
}
