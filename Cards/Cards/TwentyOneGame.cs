using System;
using System.Collections.Generic;
using System.Text;

namespace 21
{
    public class TwentyOneGame : Game, IWalkAway
    {
    public override void Play()
    {
        throw new NotImplementedException();
    }
    public override void ListPlayer()
    {
        Console.WriteLine("21 Players:");
        base.ListPlayers();
    }
    public void WalkAway(Player player)
    {
        throw new NotImplementedException();
    }
}
}
