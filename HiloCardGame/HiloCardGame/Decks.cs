using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiloCardGame
{
    class Decks
    {
        private List<Cards> _Card = new List<Cards>();
        private int _NCard = 52;
        Random rand = new Random();

        public Decks()
        {
            for (int i = 1; i <= 13; i++)
            {
                Cards d = new Cards("Clubs", i);
                _Card.Add(d);
            }
            for (int i = 1; i <= 13; i++)
            {
                Cards d = new Cards("Spades", i);
                _Card.Add(d);
            }
            for (int i = 1; i <= 13; i++)
            {
                Cards d = new Cards("Hearts", i);
                _Card.Add(d);
            }
            for (int i = 1; i <= 13; i++)
            {
                Cards d = new Cards("Diamonds", i);
                _Card.Add(d);
            }
            
        }
        public int GetNumberOfCard()
        {
            return _Card.Count;
        }
        public Cards UseCard()
        {
            Cards c = new Cards();
            int temp;
            if (_Card.Count != 0)
            {
                temp = rand.Next(_Card.Count);
                c = _Card[temp];

                _Card.RemoveAt(temp);
                _NCard--;
            }
            return c;
        }
        public void AddCard(Cards c)
        {
            _Card.Add(c);
            _NCard++;
        }

    }
}
