﻿// Testing class StackInheritance.
using System;
using StackInheritanceLibrary;
using LinkedListLibrary;

// demonstrate functionality of class StackInheritance
class StackInheritanceTest
{
   public static void Main( string[] args )
   {
      StackInheritance stack = new StackInheritance();

      // create objects to store in the stack
      bool aBoolean = true;
      char aCharacter = '$';
      int anInteger = 34567;
      string aString = "hello";

      // use method Push to add items to stack
      stack.Push( aBoolean );
      stack.Display();
      stack.Push( aCharacter );
      stack.Display();
      stack.Push( anInteger );
      stack.Display();
      stack.Push( aString );
      stack.Display();

      // remove items from stack
      try
      {
         while ( true )
         {
            object removedObject = stack.Pop();
            Console.WriteLine( removedObject + " popped" );
            stack.Display();
         } // end while
      } // end try
      catch ( EmptyListException emptyListException )
      {
         // if exception occurs, write stack trace
         Console.Error.WriteLine( emptyListException.StackTrace );
      } // end catch
   } // end Main
} // end class StackInheritanceTest