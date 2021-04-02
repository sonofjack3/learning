// Demonstrating how the value of "this" changes depending on context
// Function
function myFunction(text: string) {
    // Value of "this" is the Window (aka "global scope")
    console.log("Function:::", this, text);
}
myFunction('ABC');

// Object literal
const myObj = {
    myMethod() {
        // Value of "this" is the object literal
        console.log("Object:::", this);
    }
};
myObj.myMethod();

// Classes
class MyClass {
    myMethod() {
        // Value of "this" is the object created from the class
        console.log("Class:::", this);
    }
}
const myInstance = new MyClass();
myInstance.myMethod();

// Demonstrating use of call/bind/apply
myFunction('ABC');
// call function changes the value of this - basically, we're calling myFunction with the "context" of myObj. The first argument is always used as "this" within
// the scope of the function; arguments after that are used as the actual arguments of the function itself.
myFunction.call(myObj, 'DEF');
// Likewise, calling the function on an array
myFunction.call([], "GHI");

// apply is identical to call, the difference being is that the second argument is an array of the function's arguments
myFunction.apply(myObj, ['DEF']);

// bind "binds" the context to a function so that "this" will always be the same whenever it is called
const boundFunction = myFunction.bind(myObj);
// Arguments to a bound function are passed the same way as with "call"
boundFunction('123');
boundFunction('456');
boundFunction('789');

// Demonstrating arrow functions and lexical scope
class MyLexicalScopeClass {
    myMethod() {
        const foo = 123;
        // Value of "this" is the object created from this class
        console.log('1', this);
        setTimeout(function() {
            // "this" has global scope in this case. The object scope has been "lost" (in actuality, it is "re-bound")
            console.log('2', this);
        }, 0);
        setTimeout(() => {
            // When using arrow functions, the scope of "this" is not lost (in actuality, it is not "re-bound"), so the value again will be the object created from this class
            console.log('3', this);
        }, 0);
    }
}

const myLexicalObjectInstance = new MyLexicalScopeClass();
myLexicalObjectInstance.myMethod();

// Demonstrating how "this" behaves with HTML elements, and how to supply the type of "this"
const elem = document.querySelector('.click');
function handleClick(this: HTMLAnchorElement, event: Event) {
    event.preventDefault();
    // The scope of "this" is the element that this method has been "linked with" (i.e. the "Click" link). 
    // Also, the type of "this" can be supplied in the function parameter, but this is simply so that TypeScript can infer the type; it in no way affects the value of "this", 
    // or the order of the arguments.
    // "noImplicitThis" in tsconfig forces the type of "this" to be supplied.
    console.log(this.href);
    console.log(this.className);
}
elem.addEventListener('click', handleClick, false);

// Demonstrating typeof "Type queries"
const person = {
    name: 'Todd',
    age: 27
}

// typeof person is a "Type query" whose value can be assigned to a new Type
type Person = typeof person;

const anotherPerson: Person = {
    name: 'Evan',
    age: 29
}

// Demonstrating "keyof" 
// keyof gives the keys of an object as a "union" type - note, however, that the types of the keys are "string literals" (hover over PersonKeys to see)
type PersonKeys = keyof Person; 
// By doing the following, the string literal types are converted to actual types (string | number rather than "name" | "age")
type PersonTypes = Person[PersonKeys];

function getProperty<T, K extends keyof T>(obj: T, key: K) {
    return obj[key];
}
// 'name' extends the keyof the person object, which is 'name' | 'age'
const personName = getProperty(person, 'name');

// Demonstrating "Mapped Types"

// Demonstrating the "Readonly" Mapped Type
interface PersonInterface {
    name: string;
    age: number;
}

const person1: PersonInterface = {
    name: 'Todd',
    age: 27
};

// Note that the inferred type of frozenPerson is Readonly<PersonInterface> - a mapped Type
const frozenPerson = Object.freeze(person1);

// This is how Readonly figures out the keys of T, and marks them all readonly
type MyReadonly<T> = {
    readonly [P in keyof T]: T[P];
}

// Demonstrating the "Partial" Mapped Type
// A "Partial" type is one where all the properties are optional
function updatePerson(person: PersonInterface, property: any): Partial<PersonInterface> {
    return {...person, ...property};
}

const person2: Person = {
    name: 'Todd',
    age: 27,
}

// This is how Partial works
type MyPartial<T> = {
    // Similar to how Readonly works, Partial iterates over all the properties in a type and adds "?" to make them optional 
    [P in keyof T]?: T[P];
}

// We can just provide the name since this function constructs a "partial" object whose properties are all optional
updatePerson(person, {name: 'ABC'});

// Demonstrating the "Required" Mapped Type
interface PersonInterface2 {
    name: string,
    age?: number
}

function printAge(person: Required<PersonInterface2>) {
    return `${person.name} is ${person.age}`;
}

const requiredPerson: Required<PersonInterface2> = {
    name: 'Todd',
    age: 27
}

// This is how Required works
type MyRequired<T> = {
    // This makes all properties of type T required (syntax is funky, but think of it like "removing the optionals")
    [P in keyof T]-?: T[P];
}

// Demonstrating the "Pick" Mapped Type
// Pick allows you to make objects with only some properties of a type
interface PersonInterface3 {
    name: string;
    age: number;
    address: {};
}

const person3: Pick<Person, 'name' | 'age'> = {
    name: 'Todd',
    age: 27
}

// This is how Pick works
type MyPick<T, K extends keyof T> = {
    [P in K]: T[P];
}

// Demonstrating the "Record" Mapped Type
interface TrackStates {
    current: string;
    next: string;
}

// Record is defined as Record<K extends string | number | symbol, T> = { [P in K]: T } 
let dictionary: Record<string, TrackStates> = {}; 

const item: Record<keyof TrackStates, string> = {
    current: 'js02js9',
    next: '8nlksjsk'
}

dictionary[0] = item;

// Demonstrating Type Guards

// Old way of type-guarding
function foo(bar: string | number) {
    if (typeof bar === 'string') {
        // TypeScript is smart enough to know that bar is of type string
        bar.replace('a', 'b');
    } else {
        // TypeScript understands that, otherwise, bar must of type number
        bar.toExponential();
    }
}

// Better way of type-guarding
class Song {
    constructor(public title: string, public duration: string | number) {}
}

function getSongDuration(song: Song) {
    if (typeof song.duration === 'string') {
        return song.duration;
    } else {
        // Otherwise - assume the duration is in milliseconds, and parse it into a string

        // Recall - this destructures the object
        const { duration } = song;

        const minutes = Math.floor(duration / 60000);
        const seconds = (duration / 1000) % 60;
        return `${minutes}:${seconds}`;
    }
}

const songDurationFromString = getSongDuration(new Song('Wonderful Wonderful', '05:31'));
console.log(songDurationFromString);

const songDurationFromMs = getSongDuration(new Song('Wonderful Wonderful', 330000));
console.log(songDurationFromMs);

// Demonstrating instanceof as a Type guard
class Playlist {
    constructor(public name: string) {}
}
function getItemName(item: Song | Playlist) {
    if (item instanceof Song) {
        console.log(`Song title ${item.title}`);
    } else {
        console.log(`Playlist name ${item.name}`);
    }
}
getItemName(new Song('Wonderful Wonderful', '05:31'));
getItemName(new Playlist('My Playlist'));

// Demonstrating user-defined Type Guards
function getItemNameWithUserDefinedTypeGuards(item: Song | Playlist) {
    if (isSong(item)) {
        console.log(`Song title ${item.title}`);
    } else {
        console.log(`Playlist name ${item.name}`);
    }
}
// This is really weird, but what it's saying is that - if this function returns true, item can be inferred to be of type Song by anything that calls this function. 
// TypeScript needs this in order to infer the type of item (without it, it can only assume the type to be "any").
function isSong(item: any): item is Song {
    return item instanceof Song;
}

// Demonstrating intersection types
interface Order {
    id: string;
    amount: number;
    currency: string;
}

interface PayPal {
    email: string
} 

interface Stripe {
    card: string;
    cvc: string;
}

// &ing two types creates an "intersection type". Sort of an alternative to extending.
type OrderViaStripe = Order & Stripe;
type OrderViaPaypal = Order & PayPal;

const order: Order = {
    id: 'xj28s',
    amount: 100,
    currency: 'USD'
};

const orderViaCard: OrderViaStripe = {
    ...order,
    card: '1000 2000 3000 4000',
    cvc: '123'
}

const orderViaPayPal: OrderViaPaypal = {
    ...order,
    email: 'abc@def.com'
}

// Demonstrating interfaces vs type aliases
interface Item {
    name: string;
}

// Interfaces allow for extending...
interface Artist extends Item {
    name: string;
    songs: number;
}

// ...but types do not. Intersection types are one way around this.
type Artist2 = {
    name: string;
} & Item;

// Multiple interfaces of the same name are allowed, whereas the same is not allowed for types
interface Artist {
    getSongs(): number;
}

const newArtist: Artist = {
    name: 'ABC',
    songs: 5,
    getSongs() {
        return this.songs;
    }
}

// Demonstrating interfaces vs classes
interface Artist3 {
    name: string;
}

class ArtistCreator implements Artist3 {
    constructor(public name: string) {}
}

function artistFactory({ name }: Artist3) {
    return new ArtistCreator(name); 
}

artistFactory({name: 'Todd'});

// I don't know what his point was on this one

// Demonstrating more on generics

// Generics can be applied to classes, fields, parameters and return types
class List<T> {
    private list: T[];

    addItem(item: T): void {
        this.list.push(item);
    }

    getList(): T[] {
        return this.list;
    }
}

// Demonstrating function overloads

// We can declare the definition for each overloaded version of the function
function reverse(str: string): string;
function reverse<T>(arr: T[]): T[];

// One implementation that satisifes the above definitions. JavaScript does not allow for multiple function implementations with the same name like Java does.
function reverse<T>(stringOrArray: string | T[]): string | T[] {
   if (typeof stringOrArray === 'string') {
       return stringOrArray.split('').reverse().join('');
   } else {
       return stringOrArray.slice().reverse();
   } 
}

reverse('Pepperoni');
reverse(['bacon', 'pepperoni', 'chili', 'mushrooms']);

// Demonstrating Numeric Enums and Reverse Mappings
enum Size {
    Small,
    Medium,
    Large
}

console.log(Size.Medium); // Displays 1
console.log(Size[Size.Large]); // Displays 'Large'

enum Size {
    // ExtraLarge <- won't compile because, when enum definitions are split, leaving the first value without an index makes it ambiguous
    ExtraLarge = 3
}

// Demonstrating String Enums and Inlining Members
// Adding const has to an enum and setting strings for the values has an effect on the output JavaScript. I'm not sure why one would want to do this.
const enum Color {
    Red = 'red',
    Blue = 'blue',
    Green = 'green'
}

let selected: Color;

function updateColor(color: Color): void {
    selected = color;
}

updateColor(Color.Green);
console.log(selected);

