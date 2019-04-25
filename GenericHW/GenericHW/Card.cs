using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHW
{
    public enum CardType
    {
        six=6,
        seven=7,
        eight=8,
        nine=9,
        ten=10,
        valet=11,
        dama=12,
        korol=13,
        tuz=14
    }
    public enum  Mast
    {
        chervi,
        bubna,
        kresti,
        piki
    }
    public class Card
    {
        public CardType TypeCard { get; set; }
        public Mast Mast { get; set; }
        public Card()
        {
            Mast = new Mast();
            TypeCard = new CardType();
        }
    }
}
