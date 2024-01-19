import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ReservationListComponent } from './reservation-list/reservation-list.component';
import { ReservationRoutingModule } from './reservation-routing.module';
import { ReservationDetailResolverService } from './reservation-detail.resolver';
import { ManageComponent } from './manage/manage.component';



@NgModule({
  declarations: [
    ReservationListComponent,
    ManageComponent
  ],
  imports: [
    CommonModule,
    ReservationRoutingModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [ReservationDetailResolverService]
})
export class ReservationModule { }
