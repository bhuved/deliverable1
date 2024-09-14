// See https://aka.ms/new-console-template for more information
/* 
 Initialine the variable for stock and restock values for
soda, chips, candy
prompt the user to enter how many sold today
display the remaining stock if any. if it is over don't adjust the stock.
check with restock value, display the value needs to be restocked
 */
using System;

Console.WriteLine("***Welcome to the Restocking Tool***");
int stockSoda = 100;
int stockChips = 40;
int stockCandy = 60;

int restockSoda = 40;
int restockChips = 20;
int restockCandy = 40;

Console.WriteLine("How many sodas have been purchased today? " + stockSoda + " are in stock");
int purchaseSoda = int.Parse(Console.ReadLine());
int remainingStsoda = stockSoda - purchaseSoda;
    if (remainingStsoda > 0)
    {
        Console.WriteLine("There are " + remainingStsoda + " Sodas left");
    }
    else
    {
    Console.WriteLine("That value is too high. Stock not adjusted");
    remainingStsoda = stockSoda;
    }

Console.WriteLine("How many chips have been purchased today? " + stockChips + " are in stock");
int purchaseChips = int.Parse(Console.ReadLine());
int remainingStchips = stockChips - purchaseChips;
if (remainingStchips > 0)
{
    Console.WriteLine("There are " + remainingStchips + " Chips left");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
    remainingStchips = stockChips;
}

Console.WriteLine("How many Candy have been purchased today? " + stockCandy + " are in stock");
int purchaseCandy = int.Parse(Console.ReadLine());
int remainingStcandy = stockCandy - purchaseCandy;
if (remainingStcandy > 0)
{
    Console.WriteLine("There are " + remainingStcandy + " Candies left");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
    remainingStcandy = stockCandy;
}
Console.Write("\n\nThank you for filling out the values. ");
if ((remainingStsoda <= restockSoda) || (remainingStchips <= restockChips) || (remainingStcandy <= restockCandy))
Console.WriteLine("Here's what you needs to be restocked");
if ( remainingStsoda <= restockSoda)
{
    Console.WriteLine("Soda needs to be restocked");
}
if (remainingStchips <= restockChips)
{
    Console.WriteLine("Chips needs to be restocked");
}

if (remainingStcandy <= restockCandy)
{
    Console.WriteLine("Candy needs to be restocked");
}


