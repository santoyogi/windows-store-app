/*****************************************************
Gissel Santoyo
Final Project Submission
Date: February 8, 2023
******************************************************/

using SSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            //Using your example for output plus some modifications
            List<Inventory> inventory = new List<Inventory>();
            StoreOwner owner = new StoreOwner("Gissel", "Santoyo", "123 Main St", "111-111-1111");

            //owner.PrintOwnerInfo();

            try
            {
                FurnitureItem furnitureItem = new FurnitureItem(1, "Sofa", "Large Sofa", -100m, 1, 1, 1, 1);
            }
            catch (NegativePriceException negPriceEx)
            {
                Console.WriteLine(negPriceEx.Message);
                Console.WriteLine(negPriceEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                GroceryItem groceryItem = new GroceryItem(2, "Gala Apples", "Delicious Gala Apples", 3.45m, Category.Fruit, DateTime.Today, DateTime.Today.AddDays(-1));
            }
            catch (ExpirationException expEx)
            {
                Console.WriteLine(expEx.Message);
                Console.WriteLine(expEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                BookItem book = new BookItem(3, "A good Book", "A very good book", 100m, string.Empty, "John Doe", BookType.SciFi);
            }
            catch (ISBNException argEx)
            {
                Console.WriteLine(argEx.Message);
                Console.WriteLine(argEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //RegularCustomer customer1 = new RegularCustomer("12345", "RegO1", "MemberFirst", "MemberLast", "123 Important St", "222-222-2222");
            //PaidCustomer customer2 = new PaidCustomer("23456", "MEMBER02", 100m, "MemberSecond", "MemberLast", "345 University Ave", "333-333-3333");

            //customer1.BuysAnItem(furnitureItem2);
            //customer1.BuysAnItem(furnitureItem500Plus);
            //System.Console.WriteLine("Ensuring that the 500$ furniture discount is working");
            //customer1.PrintInfo();

            //customer2.BuysAnItem(furnitureItem2); // Cannot buy as it is already sold. 

            //customer2.BuysAnItem(furnitureItem1);
            //customer2.BuysAnItem(furnitureItem3);
            //customer2.BuysAnItem(book1);
            //customer2.BuysAnItem(groceryItem1);
            //customer2.BuysAnItem(groceryItem2);

            //System.Console.WriteLine("sanity check + discount check");
            //customer2.PrintInfo();

            //customer2.BuysAnItem(furnitureItem5); // limit reached. 


            System.Console.ReadLine();
        }
    }
}





//FurnitureItem furnitureItem1 = new FurnitureItem(1, "Sofa", "Reclining one", 800m, 6m, 3m, 2m, 40);
//FurnitureItem furnitureItem2 = new FurnitureItem(2, "Chair", "Non Reclining beige color", 50m, 1m, 1m, 1m, 10);
//FurnitureItem furnitureItem3 = new FurnitureItem(3, "Dinning Table", "Nice and Strong", 3000m, 8m, 2m, 1m, 200);
//FurnitureItem furnitureItem4 = new FurnitureItem(4, "Bed", "Cool and Comfy", 1100m, 8m, 2m, 1m, 100);

//owner.AddsAnItem(furnitureItem1, inventory);
//owner.AddsAnItem(furnitureItem2, inventory);
//owner.AddsAnItem(furnitureItem3, inventory);
//owner.AddsAnItem(furnitureItem4, inventory);

//GroceryItem groceryItem1 = new GroceryItem(5, "Bulk apples", "Too many apples", 20m, Category.Fruit, DateTime.Today, DateTime.Today.AddDays(14));
//GroceryItem groceryItem2 = new GroceryItem(6, "30 lb Meat", "Too much meat", 200m, Category.Fruit, DateTime.Today, DateTime.Today.AddDays(10));
//GroceryItem groceryItem3 = new GroceryItem(6, "Cereal Box", "Frosty Flakes", 6m, Category.Produce, DateTime.Today, DateTime.Today.AddDays(30));
//GroceryItem groceryItem4 = new GroceryItem(6, "Orange Juice", "Juice of oranges", 3m, Category.Beverages, DateTime.Today, DateTime.Today.AddDays(30));

//BookItem book1 = new BookItem(7, "A Good Programming Book", "A very good book", 500m, "1-1-11-1111", "Karen S", BookType.NonFiction);
//BookItem book2 = new BookItem(8, "An Excellent English Grammer Book", "A very good but costly grammar book", 1000m, "2-2-22-2222", "Dave D", BookType.NonFiction);

//owner.AddsAnItem(groceryItem1, inventory);
//owner.AddsAnItem(groceryItem2, inventory);
//owner.AddsAnItem(groceryItem3, inventory);
//owner.AddsAnItem(groceryItem4, inventory);
//owner.AddsAnItem(book1, inventory);
//owner.AddsAnItem(book2, inventory);

////System.Console.WriteLine("Printing inventory for sanity check");
////inventory.ForEach(x => x.PrintInfo(inventory));


////testing of clone 
//BookItem book3 = (BookItem)book2.Clone();
//BookItem book4 = (BookItem)book2.Clone();
////System.Console.WriteLine("Ensuring that the itemid is unique");
////book2.PrintInfo(inventory);
////book3.PrintInfo(inventory);
////book4.PrintInfo(inventory);
//owner.AddsAnItem(book3, inventory);
//owner.AddsAnItem(book4, inventory);

//System.Console.WriteLine("\n*********************** 1. Find all the furniture items in the inventory. ************************* ");
//List<Inventory> furniture = new List<Inventory>();
//for (int i = 0; i < inventory.Count; i++)
//{
//    if (inventory[i] is FurnitureItem)
//    {
//        furniture.Add(inventory[i]);
//    }
//}
//furniture.ForEach(x => x.PrintInfo(furniture));


//System.Console.WriteLine("\n*********************** 2. Find all the items in the inventory that are priced less than 50$. *************************");
//List<Inventory> UnderFifty = inventory.Where(x => x.Price < 50m).ToList();
//UnderFifty.ForEach(x => x.PrintInfo(UnderFifty));


//System.Console.WriteLine("\n*********************** 3. Find all the grocery items that are priced less than 10$. ************************* ");
//List<Inventory> grocery = new List<Inventory>();
//for (int i = 0; i < inventory.Count; i++)
//{
//    if (inventory[i] is GroceryItem)
//    {
//        grocery.Add(inventory[i]);
//    }
//}
//List<Inventory> groceryUnderTen = grocery.Where(x => x.Price < 10m).ToList();
//groceryUnderTen.ForEach(x => x.PrintInfo(groceryUnderTen));

//System.Console.WriteLine("\n*********************** 4. Find all the books in the inventory whose author is 'John Doe'. ************************* ");

//System.Console.WriteLine("\n*********************** 5. Sort the shop items in descending order by price. ************************* ");
//List<Inventory> descendingPrice = inventory.OrderByDescending(x => x.Price).ToList();
//descendingPrice.ForEach(x => x.PrintInfo(descendingPrice));

//System.Console.WriteLine("\n*********************** 6. Find and sort all the books in ascending order by the title. ************************* ");

//System.Console.WriteLine("\n*********************** 7. Find the costliest item in the inventory. ************************* ");
//decimal highestPrice = inventory.Max(x => x.Price);
//List<Inventory> HighItem = inventory.Where(x => x.Price == highestPrice).ToList();
//HighItem.ForEach(x => x.PrintInfo(HighItem));

//System.Console.WriteLine("\n*********************** 8. Find the average price of grocery items. ************************* ");
//decimal averageGrocery = grocery.Average(x => x.Price);
//System.Console.WriteLine("Average price of groceries: $" + averageGrocery);
