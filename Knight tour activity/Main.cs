/*
Elizabeth Rodríguez Fallas
A01334353 
Knight's tour  
*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Board creation");

    Board board = new Board(); 
    board.printBoard(); 

    Console.WriteLine ("Knight creation");
    Random random = new Random();  
    int randomXPos = random.Next(0, 9);
    int randomYPos = random.Next(0, 9);
    Knight knight = new Knight(randomXPos,randomYPos,board);
    Console.WriteLine ("Knight positionx: "+ randomXPos + " y: "+randomYPos);
    

    board.printBoard(); 


    Console.WriteLine ("Start of searching tour");
    knight.searchTour();
  }
}
