using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Card 
    {
        
        public int value = 0;

        public Card() // constructing the new instance of Die
        {

        }
        public void getCard()
        {
            
            Random r = new Random(); // generating a random value for getting a card.
            value = r.Next(1,14);


        }

    }
}
