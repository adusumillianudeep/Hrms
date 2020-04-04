import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { FlexLayoutModule } from '@angular/flex-layout';

import { FuseDirectivesModule } from '@fuse/directives/directives';
import { FusePipesModule } from '@fuse/pipes/pipes.module';
import {
    MatToolbarModule,
    MatSidenavModule,
    MatListModule, MatButtonModule, MatIconModule, MatDividerModule, MatSelectModule, MatTableModule, MatFormFieldModule, MatInputModule, MatDialogModule, MatMenuModule, MatCardModule, MatSnackBarModule, MatPaginatorModule, MatCheckboxModule, MatTooltipModule, MatExpansionModule,
    MatStepperModule
} from '@angular/material';

import { NgxDatatableModule } from '@swimlane/ngx-datatable';

@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        FlexLayoutModule,
        FuseDirectivesModule,
        FusePipesModule,
        MatToolbarModule,
        MatSidenavModule,
        MatListModule,
        MatButtonModule,
        MatIconModule,
        MatDividerModule,
        MatSelectModule,
        MatTableModule,
        MatFormFieldModule,
        MatInputModule,
        MatDialogModule,
        MatStepperModule,

        MatMenuModule,
        MatCardModule,
        MatSnackBarModule,
        MatPaginatorModule,
        MatCheckboxModule,
        FormsModule,
        MatTooltipModule,
        NgxDatatableModule,
        MatExpansionModule
    ],
    exports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        MatToolbarModule,
        MatSidenavModule,
        MatListModule,
        MatButtonModule,
        MatIconModule,
        MatDividerModule,
        MatSelectModule,
        MatTableModule,
        MatFormFieldModule,
        MatInputModule,
        MatDialogModule,
        MatStepperModule,

        MatMenuModule,
        MatCardModule,
        MatSnackBarModule,
        MatPaginatorModule,
        MatTooltipModule,
        MatCheckboxModule,
        FlexLayoutModule,
        FuseDirectivesModule,
        FusePipesModule,
        NgxDatatableModule,
        MatExpansionModule
    ]
})
export class FuseSharedModule {
}
