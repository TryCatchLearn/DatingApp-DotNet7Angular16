import { provideHttpClient, withInterceptors, withInterceptorsFromDi } from "@angular/common/http";
import { ApplicationConfig, importProvidersFrom } from "@angular/core";
import { provideAnimations } from "@angular/platform-browser/animations";
import { provideRouter, RouteReuseStrategy } from "@angular/router";
import { provideToastr } from "ngx-toastr";
import { errorInterceptor } from "./_interceptors/error.interceptor";
import { jwtInterceptor } from "./_interceptors/jwt.interceptor";
import { loadingInterceptor } from "./_interceptors/loading.interceptor";
import { CustomRouteReuseStrategy } from "./_services/customRouteReuseStrategy";
import { routes } from "./app.routes";
import { NgxSpinnerModule } from "ngx-spinner";
import { TimeagoModule } from "ngx-timeago";
import { ModalModule } from "ngx-bootstrap/modal";

export const appConfig: ApplicationConfig = {
    providers: [
        provideRouter(routes),
        provideToastr({
            positionClass: 'toast-bottom-right'
        }),
        importProvidersFrom(NgxSpinnerModule, TimeagoModule.forRoot(), ModalModule.forRoot()),
        { provide: RouteReuseStrategy, useClass: CustomRouteReuseStrategy },
        provideHttpClient(
            withInterceptors([errorInterceptor, jwtInterceptor, loadingInterceptor]),
            withInterceptorsFromDi()
        ),
        provideAnimations()
    ]
}