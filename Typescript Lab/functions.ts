import { InventoryItem } from "./inventoryItem";
import { Mountain } from "./mountain";
import { Product } from "./product";

export function findNameOfTallestMountain(mountainArray:Mountain[])
{
    let tallestMountain:Mountain = mountainArray[0];

    for(let mountain of mountainArray){
        if (tallestMountain.height < mountain.height)
        {
            tallestMountain = mountain;
        }
    }
    
    return tallestMountain;
}

export function calcAverageProductPrice(productArray:Product[]){

    let sumOfProducts:number = 0;
    let numberInArray:number = productArray.length;

    for(let product of productArray)
    {
        sumOfProducts = sumOfProducts + product.price;
    }

    return sumOfProducts/numberInArray;
}

export function calcInventoryValue(inventory:InventoryItem[])
{
    let sumOfInventoryValue:number = 0;

    for (let item of inventory)
    {
        let grossItemValue:number = item.product.price * item.quantity;  

        sumOfInventoryValue = sumOfInventoryValue + grossItemValue;
    }
    return sumOfInventoryValue;

}