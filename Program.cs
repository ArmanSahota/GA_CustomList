using System;
namespace GA_CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom List Class Example!");
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Hello");
            myList.AddAtIndex("World", 1);
            // More tests for adding, removing, and retrieving items

            // adding world spelled worng
            myList.Add("Wrld");


            // checking if add works
            for (int i = 0; i < myList.Count; i++)
            {
                string v = myList.GetItem(i).ToString();
                Console.WriteLine(v);
            }

            // checking if mylist.getitem works
            Console.WriteLine("Item 0 is: " + myList.GetItem(0));
            
            // checking if remove item works

            myList.Remove("Wrld");
            
            for (int i = 0; i < myList.Count; i++)
            {
                string v = myList.GetItem(i).ToString();
                Console.WriteLine(v);
            }

            // checking if addatindex 
            myList.AddAtIndex("JohnCena", -1);
            // only works if there are the amount of items present. if there are only 2 items u can not index 5 only index between 0-2
            for (int i = 0; i < myList.Count; i++)
            {
                string v = myList.GetItem(i).ToString();
                Console.WriteLine(v);
            }


        }

    }
}
