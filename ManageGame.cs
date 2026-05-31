using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orbit
{
    public class ManageGame
    {

        private Board GameBoard;

        private bool IsBlackTurn;

        public ManageGame()
        {
            GameBoard = new Board();
            IsBlackTurn = true;
        }

        public bool putBall(Location location, Troop troop)
        {
            int currentTroop = GameBoard.GetTroopAt(location);
            if (currentTroop != (int)Troop.NO_TROOP)
                return false;
            GameBoard.PlaceTroop(location, troop);
            return true;
        }

        public bool moveBall(Location from, Location to)
        {
            int currentTroop = GameBoard.GetTroopAt(from);
            if (currentTroop != (int)Troop.WHITE_TROOP && currentTroop != (int)Troop.BLACK_TROOP)
                return false;
            GameBoard.PlaceTroop(from, Troop.NO_TROOP);
            GameBoard.PlaceTroop(to, (Troop)currentTroop);
            return true;
        }
        


    }
}
