// Demonstrating map function
const pizzas = [
    { name: 'Pepperoni', toppings: ['pepperoni'] }
]

const mappedPizzas = pizzas.map(pizza => pizza.name.toUpperCase());

console.log(mappedPizzas);

// Demonstrating arrow functions
const pizza = {
    name: 'Blazing Inferno',
    getName: function() {
        setTimeout(() => {
            console.log(this.name);
        }, 100)
    }
}

console.log(pizza.getName);

// Demonstrating default parameters
function multiply(a: any, b = 25) {
    return a * b;
}

console.log(multiply(5, 25));
console.log(multiply(5));

// Demonstrating object literals
const peppPizza = {
    name: 'Pepperoni',
    price: 15,
    // "Object literals" mean that properties that are actually functions can be declared like this
    getName() {
        return this.name;
    }
}

const toppingsArray = ['pepperoni'];

const order = {peppPizza, toppings: toppingsArray};

console.log(order);

// Demonstrating rest parameters (varargs)

function sumAll(message: any, ...arr: number[]) {
    console.log(message);
    return arr.reduce((prev, next) => prev + next);
}

console.log(sumAll("Sum of numbers 1-10:", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

// Demonstrating array spread operator

const toppings2 = ['bacon', 'chilli'];

const newToppings = ['pepperoni'];

// "Spread" operator copies the contents of the arrays and merges them
const allToppings = [...toppings2, ...newToppings];

console.log(allToppings);

// Demonstrating object spread operator

const pizza2 = {
    name: 'Pepperoni'  
};

const toppings3 = ['pepperoni'];

// As above, only a copy of pizz2 is placed into the object
const order2 = {
    ...pizza2,
    toppings: toppingsArray
}

console.log(order2);

// Demonstrating "destructering" of arrays/objects

const pizza3 = {
    name: 'Pepperoni',
    toppings: ['pepperoni']
};

function order3({name, toppings}) {
    console.log(name, toppings);
}

// Destructuring magically pulls the name and toppings properties out of the object
order3(pizza3);

// Similarly, destructuring works with arrays 
const toppings4 = ['pepperoni', 'bacon', 'chilli'];
const [first, second, third] = toppings4
console.log(first, second, third)

// Demonstrating how implicit types are picked up

let pizzaCost = 10;
//pizzaCost = "test"; // <- This won't compile; TypeScript inferred the type even though we didn't make it explicit

let cost: number = 25; 
let toppingsNum: number = 2;

function calculatePrice(cost: number, toppings: number): number {
    return cost + 1.5 * toppings;
}

const totalCost = calculatePrice(cost, toppingsNum);
console.log(`Pizza costs in total: ${totalCost}`);

// Demonstrating String types/literals
const couponCode: string = 'pizza25';

function normalizeCoupon(code: string): string {
    return code.toUpperCase();
}

// Use backticks for strings that can have function outputs substituted in
const couponMessage: string = `Final coupon is ${normalizeCoupon(couponCode)}`;

console.log(couponMessage);

// Demonstrating Boolean types/literals
const numberOfPizzas: number = 5;

function offerDiscount(orders: number): boolean {
    return orders >= 3;
}

if (offerDiscount(numberOfPizzas)) {
    console.log("Congrats you gots a discount");
} else {
    console.log("Frig off ya peasant");
}

// Demonstrating the "any" type
let explicitAnyType: any;
let implicitAnyType;

explicitAnyType = 'pizza25';
explicitAnyType = 25;
implicitAnyType = 'pizza25';
implicitAnyType = 25;
// In general, the any type should be avoided unless as a last resort

// Demonstrating implicit/explicit types
let implicitString = 'pizza25';
let explicitString: string = 'pizza25';
// implicitString = 25; <- won't compile
// explicitString = 25; <- also won't compile

// Demonstrating void return type
let selectedTopping: string = 'pepperoni';

// Leaving out return type and having no return implicitly makes the return-type "void" 
function selectTopping(topping: string) {
    selectedTopping = topping;
}

selectTopping('bacon');

console.log(selectedTopping);

// Demonstrating the "never" type
function orderErrorExplicit(error: string): never {
    throw new Error(error);
}

function orderErrorImplicit(error: string) {
    throw new Error(error);
}

// "never" return type is more or less documentation to indicate that a function never will return any value. 
// It is functionally the same as void (notice that function directly above has implict return type of void).

// Demonstrating null, undefined and strict null checks
let couponExplicit: string | null = 'pizza25';
let couponImplicit = 'pizza25';

function removeCoupon(): void {
    couponExplicit = null;
    // couponExplicit = undefined; <- won't compile
    // couponImplicit = null; <- won't compile when "strict" is true in tsconfig
}

console.log(couponExplicit);
console.log(couponImplicit)
removeCoupon();
console.log(couponExplicit);
console.log(couponImplicit);

// Demonstrating union/literal types
let pizzaSize: string = 'small';

// Pipe character denotes "union" types, even though in the case below they're kinda acting like variables/enum values
function selectSize(size: 'small' | 'medium' | 'large'): void {
    pizzaSize = size;
}

selectSize('medium');
// selectSize('meduim'); <- won't compile

console.log(`Pizza size: ${pizzaSize}`);

// Demonstrating Function types
// A function can be declared prior to being actually defined
let sumOrder: (price: number, quantity: number) => number;
sumOrder = (x, y): number => x * y;

const sum = sumOrder(25, 2);

console.log(`Total sum: ${sum}`);

// Alternatively, just declare with the "Function" type, if we don't know the details of the signature ahead of time
let sumOrderFunctionType: Function;
sumOrderFunctionType = (price: number, quantity: number): number => {
    return price * quantity;
}

// Demonstrating optional arguments
// Question-mark denotes an optional argument
function sumOrderWithOptionalQuantity(price: number, quantity?: number): number {
    if (quantity) {
        return price * quantity;
    } else {
        return price;
    }
}
const sumWithoutSupplyingQuantity = sumOrderWithOptionalQuantity(25);
const sumWithQuantitySupplied = sumOrderWithOptionalQuantity(25, 2);
console.log(`Total cost of one pizza ${sumWithoutSupplyingQuantity}`);
console.log(`Total cost of 2 pizzas ${sumWithQuantitySupplied}`);

// Demonstrating default params
function sumOrderWithDefaultParams(price: number, quantity: number = 1): number {
    return price * quantity;
}

console.log(`Total cost of one pizza ${sumOrderWithDefaultParams(25)}`);
console.log(`Total cost of 2 pizzas ${sumOrderWithDefaultParams(25, 2)}`);

// Demonstrating Object types
// Objects can be declared such that their fields are restricted (sort of like proto-classes)
let pizzaObject: {name: string, price: number};
pizzaObject = {
    name: 'Plain Old Pepperoni',
    price: 20
};

let pizzaObject2: {name: string, price: number, foo: string };
// The instantiation below won't compile because the declaration above requires a third paramter
// pizzaObject2 = {
//     name: 'Plain Old Pepperoni',
//     price: 20
// }
// 

// Functions can be declared too
let pizzaObject3: {name: string; price: number; getName(): string};
pizzaObject3 = {
    name: 'Plain Old Pepperoni',
    price: 20,
    getName() {
        return pizzaObject3.name;
    }
}
console.log(pizzaObject3.getName());

// Demonstrating array types and generics
let sizes: string[];
sizes = ['small', 'medium', 'large'];

// Array is a "generic" type (basically the way it works in Java)
let toppingsArrayTyped: Array<string>;
toppingsArrayTyped = ['pepperoni', 'tomato', 'bacon'];

// Demonstrating tuple type arrays
// Similar to with objects, we can restrict the type/order of items in an array (called "tuple-type" arrays)
let pizzaAsTupleTypeArray: [string, number, boolean];
pizzaAsTupleTypeArray = ['pepperoni', 20, true];
// pizzaAsTupleTypeArray = [20, 'pepperoni', true]; <- won't compile

// Demonstrating alias types
type Size = 'small' | 'medium' | 'large';

let pizzaSize2: Size = 'small';

const selectSizeFunc = (size: Size) => {
    pizzaSize2 = size
}

selectSizeFunc('small');

// Demonstrating type assertions
type Pizza = { name: string, toppings: number };
const blazingInfernoPizza: Pizza = { name: 'Blazing Inferno', toppings: 5};

const serializedPizza = JSON.stringify(blazingInfernoPizza);

function getNameFromJSON(obj: string) {
    // Keyword "as" is a type assertion that the object return will be of type Pizza (it's basically casting)
    return (JSON.parse(obj) as Pizza).name;
}

console.log(`${getNameFromJSON(serializedPizza)}`);

// Demonstrating interfaces
// Interface is a special type that is used to define the structure of an item, but as of 2021 it is VERY similar to using "type"
interface Sizes {
    sizes: string[];
}

// Inheriting an interface allows the child interface to gain the properties of the parent
interface PizzaInterface extends Sizes {
    name: string;
    toppings?: number; //optional property
    getAvailableSizes(): void;
    [key: number]: string; //index signature that allows objects of this type to be indexed - for example, if the values come from a database
}

let pizza4: PizzaInterface;

function createPizza(name: string, sizes: string[]): PizzaInterface {
    return {
        name,
        sizes,
        getAvailableSizes() {
            return this.sizes;
        }
    }
}

pizza4 = createPizza('Pepperoni', ['small', 'medium']);
pizza4.toppings = 1;
pizza4[1] = "pizza4ID";

// Demonstrating classes
class SizesClass {
    constructor(protected sizes2: string[]) {}

    // Getter/setter functions make it appear as if the object has properties with these names. Obviously set allows for modification, get allows for access.
    set availableSizes(sizes2: string[]) {
        this.sizes2 = sizes2;
    }

    get availableSizes() {
       return this.sizes2; 
    }
}

const sizes3 = new SizesClass(['small', 'medium']);
console.log(sizes3);
sizes3.availableSizes = ['medium', 'large'];
sizes3.availableSizes;
console.log(sizes3);

class Pizza2 extends SizesClass {
    // By default fields are "public"
    toppings: string[];

    // Adding access modifier in the constructor params automatically binds the parmeter to fields in the class with that access scope
    constructor(private name: string, readonly id: string, sizes: string[]) {
        super(sizes);
        this.toppings = [];
    }

    public updateSizes(sizes: string[]) {
        this.sizes2 = sizes;
    }

    addTopping(topping: string) {
        this.toppings.push(topping);
    }
}

const pizza5 = new Pizza2('Pepperoni', 'pizza5', ['small', 'medium']);
pizza5.addTopping('pepperoni');
// pizza5.id = 'pizza6'; <- won't compile because id is a readonly property
console.log(pizza5);
pizza5.updateSizes(['small', 'medium', 'large']);
console.log(pizza5);

// Demonstrating abstract classes
abstract class AbstractSizes extends SizesClass {

}
// const abstractSizes = new AbstractSizes(); <- won't compile since the class is abstract

// Demonstrating static properties/methods
class Coupon {
    static allowed = ['Pepperoni', 'Blazing Inferno'];
    static create(percentage: number) {
        return `PIZZA_RESTAURANT_${percentage}`;
    }
}

console.log(Coupon.allowed);
console.log(Coupon.create(25));