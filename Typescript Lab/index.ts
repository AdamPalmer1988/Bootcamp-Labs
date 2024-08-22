import { calcAverageProductPrice, calcInventoryValue, findNameOfTallestMountain } from "./functions";
import { InventoryItem } from "./inventoryItem";
import { Mountain } from "./mountain";
import { Product } from "./product";

let mountains:Mountain[] = [
    {name: "Kilimanjaro", height: 19341},
    {name: "Everest", height: 29029},
    {name: "Denali", height: 20310}
];

console.log(findNameOfTallestMountain(mountains));

let productArray:Product[] = [
    {name: "Bobblehead", price: 25 },
    {name: "Lottery Ticket", price: 5},
    {name: "Screw Driver", price: 7}

];

console.log(calcAverageProductPrice(productArray));

let inventory:InventoryItem[] = [
    {product: {name: "motor", price: 10.00}, quantity: 10},
    {product: {name: "sensor", price: 12.50}, quantity: 4},
    {product: {name: "LED", price: 1.00}, quantity: 20}
]

console.log(calcInventoryValue(inventory));