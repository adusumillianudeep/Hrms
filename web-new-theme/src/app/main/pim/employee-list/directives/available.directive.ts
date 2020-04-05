import { Directive, Input, TemplateRef, ViewContainerRef, OnChanges } from '@angular/core';

@Directive({
  selector: '[available]'
})
export class AvailableDirective implements OnChanges {

  @Input()
  availableFields: any;

  @Input()
  available: string;

  constructor(
    private templateRef: TemplateRef<any>,
    private viewContainer: ViewContainerRef
  ) { }

  ngOnChanges() {
    const show = this.availableFields.find(t => t.name === this.available && t.available)
    if (show) {
      this.viewContainer.createEmbeddedView(this.templateRef);
    } else {
      this.viewContainer.clear();
    }

  }

}
