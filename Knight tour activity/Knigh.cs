/*
Elizabeth Rodríguez Fallas
A01334353 
Knight's tour 
*/

using System;
using System.Collections.Generic;

class Knight {
  public int xPosition; 
  public int yPosition; 
  public Board board; 
  public int count;
  
  public Knight(int randomX, int randomY, Board board){
    xPosition = randomX; 
    yPosition = randomY; 
    this.board = board; 
    board.setKnightPosition(xPosition,yPosition);
    count = 1; 
  }

  public bool searchTour(){
    Console.WriteLine("SEARCH TOUR "+ count);
    count++; 
    
      // From current position calculate possible future possitions and its weight 
      int[,] posCoord = calculatePositions(this.xPosition, this.yPosition);
      List<int[]> posCoordValues = valueFuturePositions(posCoord);
      displayValues(posCoordValues);
      // mark current position as past position 
      board.setValueForPosition(this.xPosition, this.yPosition, -1); 
      board.resetBoard();
      if(board.allVisited() ){ // validar si se visitaron todos 
        board.setValueForPosition(this.xPosition, this.yPosition, -1); 
        return true; 
      }
      // change position to next position
      int[] nextPos = chooseNextPosition(posCoordValues); 
      this.xPosition = nextPos[0];
      this.yPosition = nextPos[1]; 
      board.setValueForPosition(this.xPosition, this.yPosition, 11); 
      // repeat logic
      searchTour(); 
      return true; 


  }

  public int countFuturePossibilities(int x, int y){
    int count = 0; 
    int[,] values = calculatePositions(x,y);
    for(int i = 0; i < values.GetLength(0); i++){
      if(isInBoard(values[i,0],values[i,1])){
          if(board.getBoardValues(values[i,0],values[i,1]) == 0){
              count += 1; 
          }
       }
    }
    return count; 
  }

  public List<int[]> valueFuturePositions(int[,] posCoord){
    List<int[]> possibleValues = new List<int[]>();
    for(int i = 0; i <  posCoord.GetLength(0); i++){
      if(isInBoard(posCoord[i,0], posCoord[i,1])){
        if(board.getBoardValues(posCoord[i,0],posCoord[i,1]) != -1 ){
          int[] possibilities = new int[3];
          possibilities[0] = posCoord[i,0]; // x coordinate 
          possibilities[1] = posCoord[i,1]; // y coordinate 
          possibilities[2] = countFuturePossibilities(possibilities[0], possibilities[1]); //count 
          possibleValues.Add(possibilities); 
        }
        
      }
    }
    return possibleValues; 
  }
  
  public bool isInBoard(int x, int y){
    if(x >= 0 && x <= 9 && y >= 0 && y <= 9){
      return true;
    }
    return false; 
  }


  public int[] chooseNextPosition(List<int[]> valueList){
    int minIndex = 0; 
    int minValue = valueList[0][2];
    for(int i = 1; i < valueList.Count; i++){
      Console.WriteLine("start of method choose next position");
      if(minValue > valueList[i][2]){
          minValue = valueList[i][2];
          minIndex = i; 
      }
    }
    int[] nextCoord = {valueList[minIndex][0],valueList[minIndex][1] };
    return nextCoord;
  }

  // calculate positions from coordinate 
  public int[,] calculatePositions(int x, int y){
    int[,] possibilities = new int[8,2]; 
    // A
    possibilities[0,0] = x+2; // x coordinate 
    possibilities[0,1] = y+1; // y coordinate 

    // B 
    possibilities[1,0] = x+1;
    possibilities[1,1] = y+2;

    // C
    possibilities[2,0] = x-1;
    possibilities[2,1] = y+2;

    // D
    possibilities[3,0] = x-2;
    possibilities[3,1] = y+1;

    // E
    possibilities[4,0] = x-2;
    possibilities[4,1] = y-1;

    // F
    possibilities[5,0] = x-1;
    possibilities[5,1] = y-2;

    // G 
    possibilities[6,0] = x+1;
    possibilities[6,1] = y-2;

    // H
    possibilities[7,0] = x+2;
    possibilities[7,1] = y-1;

  
    return possibilities; 
  }

  public void displayValues(List<int[]> posValues){
    for(int i = 0; i < posValues.Count;i++){
      board.setValueForPosition(posValues[i][0], posValues[i][1], posValues[i][2]);
    }
    board.printBoard(); 
  }

  

}