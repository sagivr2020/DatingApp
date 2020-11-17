import {Injectable} from '@angular/core';
import {User} from '../_models/User';
import {Resolve, Router, ActivatedRouteSnapshot} from '@angular/router';
import {UserService} from '../_services/user.service';
import {AlertifyService} from '../_services/alertify.service';
import {Observable, of} from 'rxjs';
import {catchError} from 'rxjs/operators';
import { AuthService } from '../_services/auth.service';

@Injectable()
export class MemeberEditResolver implements Resolve<User> {
    constructor(private userService: UserService, private router: Router,
                private authService: AuthService, private alertify: AlertifyService) {}

    resolve(route: ActivatedRouteSnapshot): Observable<User> {

        return this.userService.getUser(this.authService.decodeToken.nameid).pipe(
            catchError(error => {
                this.alertify.error('Problem retreiving data');
                this.router.navigate(['/members']);
                return of(null);
            })
        );

    }

}
