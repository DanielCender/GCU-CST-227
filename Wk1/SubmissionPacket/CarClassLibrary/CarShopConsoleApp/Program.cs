using System;
using CarClassLibrary;

namespace CarShopConsoleApp
{
    class MainClass
    {
        static Store CarStore = new Store();
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("Welcome to the car store. Buy a car...or not. I don't make commission....");
            Console.Out.WriteLine("You'll need to add some cars to your shopping cart before you can checkout.");
            int action = chooseAction();
            while(action != 0)
            {
                // add case statements and do program logic
                switch(action)
                {
                    case 1:
                        // Show car selection or let user input
                        addCar();
                        break;
                    case 2:
                        // Show car selection and let user add one to cart
                        int choice = 0;
                        Console.Out.Write("Which car would you like to add to cart? (number) ");
                        choice = int.Parse(Console.ReadLine());
                        CarStore.ShoppingList.Add(CarStore.CarList[choice]);
                        printShoppingCart(CarStore);
                        break;
                    case 3:
                        // Checkout, show final selection to user
                        printShoppingCart(CarStore);
                        Console.Out.WriteLine("Your total cost today is: ${0}", CarStore.Checkout());
                        break;
                    case 0:
                    default:
                        // same for 0 or def honestly
                        // just let loop exit
                        break;
                }

                action = chooseAction();
            }
        }

        public static int chooseAction() {
            int choice = 0;
            Console.Out.WriteLine("Please choose an action: (0) to quit, (1) to add a car to the car store, and (2) to add a car to your shopping cart, and (3) to checkout.");
            if(int.TryParse(Console.ReadLine(), out choice)) {
                return choice;
            }
            Console.Out.WriteLine("That was an invalid selection, please choose another action.");
            return chooseAction();
        }

        public static void addCar()
        {
            Console.Out.WriteLine("You chose to add a car to your shopping cart.");

            Console.Out.WriteLine("Please enter a make (Ford, Mazda, Toyota, etc.): ");
            String carMake = Console.ReadLine();

            Console.Out.WriteLine("Please enter a car model (Focus, 4Runner, etc.): ");
            String carModel = Console.ReadLine();

            Console.Out.WriteLine("Please enter the car's price: ");
            Decimal carPrice = 0;
            if(!Decimal.TryParse(Console.ReadLine(), out carPrice)) {
                Console.WriteLine(string.Format("* Could not parse inputted price: ${0}", carPrice));
                return;
            }

            Console.Out.WriteLine("Please enter whether the car is new or not (boolean): ");
            Boolean isNew = false;
            if(!Boolean.TryParse(Console.ReadLine(), out isNew)) {
                Console.WriteLine(string.Format("* Could not parse inputted isNew value: ${0}", isNew));
                return;
            }

            Console.Out.WriteLine("Please enter the car's body condition (1 - 5): ");
             int bodyCondition = 0;
            if(!int.TryParse(Console.ReadLine(), out bodyCondition)) {
                Console.WriteLine(string.Format("* Could not parse inputted bodyCondition value: ${0}", bodyCondition));
                return;
            }

            // Create instance of Car with new information
            Car newCar = new Car(carMake, carModel, carPrice, isNew, bodyCondition);

            // Add car to ShoppingList
            CarStore.CarList.Add(newCar);
            printStoreInventory(CarStore);
        }

        public static void printStoreInventory(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in the store inventory: ");
            int i = 0;
            foreach(var c in carStore.CarList)
            {
                // Print contents of each car record
                Console.Out.WriteLine(string.Format("Car # - {0} {1}", i, c.Display));
                i++;
            }
        }

        public static void printShoppingCart(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in the shopping cart: ");
            int i = 0;
            foreach(var c in carStore.ShoppingList)
            {
                // Print contents of each car record
                Console.Out.WriteLine(string.Format("Car # - {0} {1}", i, c.Display));
                i++;
            }
        }
    }

}
