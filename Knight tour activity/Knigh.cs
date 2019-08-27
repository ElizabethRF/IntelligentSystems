/*
Elizabeth Rodríguez Fallas
A01334353 
Knight's tour 
*/

using System;

class Knight {
  public int xPosition; 
  public int yPosition; 
  public Board board; 
  
  public Knight(int randomX, int randomY, Board board){
    xPosition = randomX; 
    yPosition = randomY; 
    this.board = board; 
    board.setKnightPosition(xPosition,yPosition);
  }

  public void searchTour(){
    // From current position calculate possible future possitions and its weight 
    int[,] posCoord = calculatePositions(this.xPosition, this.yPosition);
    int[,] posCoordValues = valueFuturePositions(posCoord);
    displayValues(posCoordValues);
     

  }

  public int countFuturePossibilities(int x, int y){
    int count = 0; 
    int[,] values = calculatePositions(x,y);
    for(int i = 0; i < values.GetLength(0); i++){
        if(board.getBoardValues(values[i,0],values[i,1]) == 0){
            count += 1; 
        }
    }
    return count; 
  }

  public int[,] valueFuturePositions(int[,] posCoord){
    int[,] possibilities = new int[8,3];
    for(int i = 0; i <  posCoord.GetLength(0); i++){
        possibilities[i,0] = posCoord[i,0]; // x coordinate 
        possibilities[i,1] = posCoord[i,1]; // y coordinate 
        possibilities[i,2] = countFuturePossibilities(possibilities[i,0],possibilities[i,1]);
    }
    return possibilities; 
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
    possibilities[5,1] = x-2;

    // G 
    possibilities[6,0] = x+1;
    possibilities[6,1] = y-2;

    // H
    possibilities[7,0] = x+2;
    possibilities[7,1] = y-1;

  
    return possibilities; 
  }

  public void displayValues(int[,] posValues){
    for(int i = 0; i < posValues.GetLength(0);i++){
      board.setValueForPosition(posValues[i,0], posValues[i,1], posValues[i,2]);
    }
    board.printBoard(); 
  }

  

}