import * as lodash from 'lodash';
declare module 'lodash' {
    // Since we've installed the @types for lodash, this won't compile since it's not a proper augmentation. If @types/lodash was not installed, this would be allowed. 
    // export function chunk(collection: any): any[][]

    // This is an augmentation of the existing log method in 
    interface LoDashStatic {
        log(item: string): void
    }
}