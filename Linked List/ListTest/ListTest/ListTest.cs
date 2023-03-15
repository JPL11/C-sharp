// Fig. 21.5: ListTest.cs 
// Testing class List.
using System;
using LinkedListLibrary;

// class to test List class functionality
class ListTest
{
   public static void Main( string[] args )
   {
      List list = new List(); // create List container

      // create data to store in List
      bool aBoolean = true;
      char aCharacter = '$';
        byte aByte = 120;
        short aShort = 5040;
        float aFloat = 0f;
        long aLong = 40320;
      int anInteger = 34567;
      string aString = "hello";

      // use List insert methods
      list.InsertAtFront( aBoolean );
      list.Display();
      list.InsertAtFront( aCharacter );
      list.Display();
        list.InsertAtFront( aByte );
        list.Display();
        list.InsertAtFront( aShort );
        list.Display();
        list.InsertAtBack( aLong );
        list.Display();
        list.InsertAtBack( aFloat );
        list.Display();
      list.InsertAtBack( anInteger );
      list.Display();
      list.InsertAtBack( aString );
        list.Display();


        Console.WriteLine($"Number of elements in the list: {list.Count()}");

        // search for an element in the list
        int element = 5040;
        bool found = list.Search(element) != null;
        Console.WriteLine($"Element {element} found: {found}");
        // use List remove methods 
        object removedObject;

      // remove data from list and display after each removal
      try
      {
         removedObject = list.RemoveFromFront();
         Console.WriteLine( removedObject + " removed" );
         list.Display();

         removedObject = list.RemoveFromFront();
         Console.WriteLine( removedObject + " removed" );
         list.Display();

            removedObject = list.RemoveFromFront();
            Console.WriteLine(removedObject + " removed");
            list.Display();

            removedObject = list.RemoveFromFront();
            Console.WriteLine(removedObject + " removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine(removedObject + " removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine(removedObject + " removed");
            list.Display();

         removedObject = list.RemoveFromBack();
         Console.WriteLine( removedObject + " removed" );
         list.Display();

         removedObject = list.RemoveFromBack();
         Console.WriteLine( removedObject + " removed" );
         list.Display();
      } // end try
      catch ( EmptyListException emptyListException )
      {
         Console.Error.WriteLine( "\n" + emptyListException );
      } // end catch
   } // end Main
} // end class ListTest