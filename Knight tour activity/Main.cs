/*
Elizabeth Rodríguez Fallas
A01334353 
Knight's 
*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello");
    
    Board board = new Board(); 
    board.printBoard(); 

    Random random = new Random();  
    int randomXPos = random.Next(0, 9);
    int randomYPos = random.Next(0, 9);
    Knight knight = new Knight(randomXPos,randomYPos,board);
    knight.searchTour();
  }
}