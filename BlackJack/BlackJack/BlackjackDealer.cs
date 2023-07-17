using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class BlackjackDealer
    {
        public List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
