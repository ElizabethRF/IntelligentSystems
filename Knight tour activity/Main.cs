/*
Elizabeth Rodríguez Fallas
A01334353 
Knight's tour  
*/

/* 
Problem formulation
Initial state. IN(s)  Bo, Xi. Set by a random number. 
Actions. Given a state s, ACTION(s) returns the set of applicable states and their weights from s. 
Transition model. Result(s,a) returns the state from doing action a in state s. Result(IN(s),GO(t)) = IN(u)
Goal: all cells visited. 
Heuristic:  Warnsdorfs rules. 
*/


/*
Environment Characterization
Knights tour is 
- fully observable 
- deterministic 
- sequential 
- static 
- known 
*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Board creation");

    Board board = new Board(); 
    board.printBoard(); 

    Console.WriteLine ("Knight creation");
    Random random = new Random();  
    int randomXPos = random.Next(0,9);
    int randomYPos = random.Next(0,9);
    Knight knight = new Knight(randomXPos,randomYPos,board);
    Console.WriteLine ("Knight positionx: "+ randomXPos + " y: "+randomYPos);
    

    board.printBoard(); 


    Console.WriteLine ("Start of searching tour");
    knight.searchTour();
  }
}
