import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'availableOnly'
})
export class AvailableOnlyPipe implements PipeTransform {

  transform(items: any, ...args: any[]): any {
    return items.filter(t=> t.available);
  }

}
