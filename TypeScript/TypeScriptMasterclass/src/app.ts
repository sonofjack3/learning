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