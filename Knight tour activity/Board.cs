/*
Elizabeth Rodríguez Fallas
A01334353 
Knight's 
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
    for(int i = 0; i< board.GetLength(0);i++){
      for(int j = 0; j< board.GetLength(1);j++){
        Console.Write(board[i,j]); 
      }
      Console.WriteLine("");
    }
  }

  public void setKnightPosition(int xPos, int yPos){
    board[xPos,yPos]= 11; 
  }

  public void setPastPosition(int xPos, int yPos){
    board[xPos,yPos]= -1; 
  }

  public void setValueForPosition(int xPos, int yPos, int value){
    board[xPos,yPos]= value; 
  }

  // reset all except -1 and -2 
  public void resetBoard(){
      for(int i = 0; i< board.GetLength(0);i++){
        for(int j = 0; j< board.GetLength(1);j++){
          if(board[i,j] != 11 && board[i,j] != -1 ){
            board[i,j] = 0; 
          }
        }
      }
  }

  public void getBoardValues(int x, int y ){
      return board[x,y]; 
  }




}