import { Directive, Input, TemplateRef, ViewContainerRef, inject } from '@angular/core';
import { take } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Directive({
    selector: '[appHasRole]',
    standalone: true
})
export class HasRoleDirective {
  private accountService = inject(AccountService);
  @Input() appHasRole: string[] = [];
  user = this.accountService.currentUser();

  constructor(private viewContainerRef: ViewContainerRef, private templateRef: TemplateRef<any>) { }

  ngOnInit(): void {
    if (this.user?.roles.some(r => this.appHasRole.includes(r))) {
      this.viewContainerRef.createEmbeddedView(this.templateRef);
    } else {
      this.viewContainerRef.clear();
    }
  }

}
