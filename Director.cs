using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Director
    {
        Card card1 = new Card();
        Card card2 = new Card();

        
        
        bool isPlaying = true;
        int totalScore = 300;
        int gainLoss = 0;
        string guess = "";
        public void StartGame()
        {
            card1.getCard();

            do{
                GetInput();
                DoUpdates();
                DoOutputs();
            }
            while (isPlaying && totalScore > 0);

        }
        public void GetInput() //  ask user for input
        {
            Console.Write("Do you want to play? [y/n] ");
            string gameContinue = Console.ReadLine();
            isPlaying = (gameContinue == "y");
            
            
            if (isPlaying){
                Console.WriteLine($"The card is:{card1.value}");
                Console.WriteLine("Higher or Lower? [h/l] ");
                guess = Console.ReadLine();
            }
            
        }
        public void DoUpdates() // update player score
        {
            if (!isPlaying){
            return;
           }

            card2.getCard();
           
            
            if (CompareCards(card1,card2,guess) ){
                gainLoss = 100;
                totalScore = totalScore + gainLoss;
            
            }
            else{
                gainLoss = 75;
                totalScore = totalScore - gainLoss;
                
            }

            card1.value = card2.value;
           
             
        }
        public void DoOutputs(){ // outpur our score and the next card value on terminal
            if (!isPlaying){
                
            return;
           }   
        {
            Console.WriteLine($"Your Total Score is {totalScore}");
            Console.WriteLine($"The next card was {card2.value}");
            Console.WriteLine();
        }
           
        }

        public bool CompareCards(Card card1, Card card2, string guess) // comparing our card value if it is high
        {
            if (guess == "h")
            {
                return (card1.value < card2.value);
            }
            else
            {
                return (card1.value >= card2.value);
            }
        }


    }
}
