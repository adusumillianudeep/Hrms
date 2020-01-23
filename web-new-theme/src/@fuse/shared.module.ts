import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { FlexLayoutModule } from '@angular/flex-layout';

import { FuseDirectivesModule } from '@fuse/directives/directives';
import { FusePipesModule } from '@fuse/pipes/pipes.module';
import { MatToolbarModule, MatSidenavModule, MatListModule, MatButtonModule, MatIconModule, MatDividerModule, MatSelectModule, MatTableModule, MatFormFieldModule, MatInputModule, MatDialogModule, MatMenuModule, MatCardModule, MatSnackBarModule, MatPaginatorModule, MatCheckboxModule } from '@angular/material';

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
        FlexLayoutModule,
        MatMenuModule,
        MatCardModule,
        MatSnackBarModule,
        MatPaginatorModule,
        MatCheckboxModule,
        FormsModule,

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
        FlexLayoutModule,
        MatMenuModule,
        MatCardModule,
        MatSnackBarModule,
        MatPaginatorModule,
        MatCheckboxModule,
        FlexLayoutModule,
        FuseDirectivesModule,
        FusePipesModule
    ]
})
export class FuseSharedModule {
}
