import { Component, OnInit, ViewChild, ComponentFactoryResolver, SimpleChanges, Input } from '@angular/core';
import { ComponentLoaderDirective } from '../../directives/component-loader.directive';
import { PersonalDetailsComponent } from '../personal-details/personal-details.component';

@Component({
  selector: 'app-component-loader',
  templateUrl: './component-loader.component.html',
  styleUrls: ['./component-loader.component.scss']
})
export class ComponentLoaderComponent implements OnInit {

  @Input()
  componentMapping: any;

  @Input()
  section: any;

  @Input()
  allSections: any;

  @ViewChild(ComponentLoaderDirective, { static: true })
  loader: ComponentLoaderDirective;

  constructor(private componentFactoryResolver: ComponentFactoryResolver) { }

  ngOnInit() {
    this.loadComponent();
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes.selectedType && !changes.selectedType.firstChange) {
      this.loadComponent();
    }
  }

  loadComponent() {
    const item = this.componentMapping.find(f => f.name.toLowerCase() === this.section.name.toLowerCase());
    const componentFactory = this.componentFactoryResolver.resolveComponentFactory(item.component);

    const viewContainerRef = this.loader.viewContainerRef;
    viewContainerRef.clear();

    const componentRef: any = viewContainerRef.createComponent(componentFactory);

    componentRef.instance.customSections = this.allSections.filter(t => t.parentId === this.section.id && t.parentId !== t.id);
    componentRef.instance.section = this.section;
  }

}
