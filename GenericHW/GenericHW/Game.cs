using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHW
{
    class Game
    {
        public List<Player> Players { get; set; } = new List<Player>(2);
        public List<Card> Cards { get; set; } = new List<Card>(36);
        public List<Card> CardsOnBoard { get; set; } = new List<Card>();
        public void SetCardValues()
        {
            int count = Cards.Count;
            for (int i= 0;i<4;i++)
            {
                for (int j = 6; i < 15; j++)
                {
                    Cards[count].Mast = (Mast)i;
                    Cards[count].TypeCard = (CardType)j;
                }
            }
        }
        public void RandomCards()
        {
            Random random = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                var nowIndex =Cards[i];
                Cards.RemoveAt(i);
                Cards.Insert(random.Next(Cards.Count), nowIndex);
            }
        }
        public void SetCards()
        {
            SetCardValues();
            RandomCards();
            for(int i=0;i<Players.Count;i++)
            {
                Players[i].PlayerCards.Capacity = 36 / Players.Count;
                Players[i].PlayerCards = Cards.GetRange(Players[i].PlayerCards.Capacity*i, Players[i].PlayerCards.Capacity*i+1);
            }
        }
        public void PlayGame()
        {
            SetCards();
            while(Players.First().PlayerCards.Count<1||Players.Last().PlayerCards.Count < 1)
            {
                foreach(Player i in Players)
                {
                    if (CardsOnBoard.Count < 1)
                    {
                        CardsOnBoard.Add(i.PlayerCards.First());
                        i.PlayerCards.RemoveAt(0);
                    }
                    else
                    {
                        if(CardsOnBoard.Last().TypeCard < i.PlayerCards.First().TypeCard)
                        {
                            i.PlayerCards.AddRange(CardsOnBoard);
                            CardsOnBoard.Clear();
                        }
                        else
                        {
                            CardsOnBoard.Add(i.PlayerCards.First());
                            i.PlayerCards.RemoveAt(0);
                        }
                    }
                }
            }
            foreach(Player player in Players)
            {
                if (player.PlayerCards.Count == 36) Console.WriteLine( player.ToString()+"Winner!!!!");
            }
        }
    }
}
