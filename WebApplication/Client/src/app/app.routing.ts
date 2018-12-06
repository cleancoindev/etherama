import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { NotFoundPageComponent } from './components/not-found-page/not-found-page.component';
import {AddTokenComponent} from "./components/add-token/add-token.component";
import {MarketComponent} from "./components/market/market.component";
import {FaqComponent} from "./components/faq/faq.component";
import {TradeComponent} from "./components/trade/trade.component";

const appRoutes: Routes = [
  { path: '', redirectTo: 'market', pathMatch: 'full' },
  { path: 'market', component: MarketComponent },
  { path: 'faq', component: FaqComponent },
  { path: 'faq/:id', component: FaqComponent },
  { path: 'add-token', component: AddTokenComponent },
  { path: 'trade/:id', component: TradeComponent },
  { path: '**', component: NotFoundPageComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(
      appRoutes,
      {
        useHash: true,
        enableTracing: false
      }
    )
  ],
  exports: [
    RouterModule
  ],
  providers: []
})
export class AppRouting { }
