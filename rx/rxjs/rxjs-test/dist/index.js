import { Observable } from 'rxjs';
var observable = Observable.create((observer) => {
    observer.next('Hello World');
});
observable.subscribe((x) => console.log(x));
//# sourceMappingURL=index.js.map