/*
Elizabeth Rodríguez Fallas
A01334353 
Knight's tour 
*/

using System;
// current position will be represented by 11 
// free space will be represented by 0 
// visited space will be represented by -1 
class Board {
  public int[,] board; 
  public Board(){
    board = new int[10,10]; 
  }

  public void printBoard(){
    Console.WriteLine("");
    for(int i = 0; i< board.GetLength(0);i++){
      for(int j = 0; j< board.GetLength(1);j++){
        Console.Write(board[i,j] + "\t"); 
      }
      Console.WriteLine("");
    }
  }

  public void setKnightPosition(int xPos, int yPos){
    board[xPos,yPos]= 11; 
  }

  public int getBoardValues(int x, int y ){
    return board[x,y]; 
  }

  public void setValueForPosition(int xPos, int yPos, int value){
    board[xPos,yPos]= value; 
  }




}