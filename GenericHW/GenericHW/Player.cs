using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHW
{
    public class Player
    {
        public List<Card> PlayerCards { get; set; } = new List<Card>;
        public void ShowCards()
        {
            foreach(Card card in PlayerCards)
            {
                Console.WriteLine(card.TypeCard.ToString());
                Console.WriteLine(card.Mast.ToString());
                Console.WriteLine("______");
            }
        }
    }
}
