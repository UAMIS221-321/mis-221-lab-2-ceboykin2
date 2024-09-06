
//initialize variables
int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0.0;
double totalSandwichCost;
double totalToppingCost;
double baseCost;
double orderCost;

//initialize constants
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

//prompt user for # sandwiches
System.Console.WriteLine("How many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());

//prompt user for # toppings
System.Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());

//prompt user for tip
System.Console.WriteLine("Insert tip amount: ");
tip = double.Parse(Console.ReadLine());

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;

orderCost = tip + (baseCost * (1-DISCOUNT_AMOUNT));

//display order cost
System.Console.WriteLine("The total order cost is " + orderCost);
