/*
Elizabeth Rodríguez Fallas
A01334353 
Knight's 
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
  }

  public void searchTour(){
    Console.WriteLine ("Searching tour");
    // from current position calculate postiions
    // from that possibilities get values 
    int[]  valueFuturePositions(); 
    // from that values choose the smaller one 
    // move to the smallest one 
    // -> mark current place as visited in board 
    // -> change knight coordinates to new position
  

    // repeat until it reaches all the squares 
  }

    public int[] valueFuturePositions(){
       int[,] possibilities =  calculatePositions(xPosition,yPosition);
       int[] valueForPosition = new int[8]; 
        
        for(int i = 0; i <  possibilities.GetLength(0); i++){
            valueForPosition[i] = countFuturePossibilities(possibilities[i,0], possibilities[i,1]);
        }

        return valueForPosition; 

    }


    public int chooseBestPlace(int[] valueForPosition){
      int minValue  = 10; 
      int minIndex = 0;

      for(int i = 0; i <  possibilities.GetLength(0); i++){
        if(valueForPosition[i] < minValue){
            minValue = valueForPosition[i]; 
            minIndex = i; 
        }
      }

    }
  
  public int[] countFuturePossibilities(int x, int y){
    int count = 0; 
    int[,] values = calculatePositions(x,y);
    for(int i = 0; i < values.GetLength(0); i++){
        if(board.getBoardValues(values[i,0],values[i,1]) == 0){
            count += 1; 
        }
    }
    
    return count; 
  }

  // calculate positions from coordinate 
  public int[,] calculatePositions(int x, int y){
    int[,] possibilities = new int[8,2]; 
    // A
    possibilities[0,0] = x+2;
    possibilities[0,1] = y+1;
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



  

}