using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameCaro
{
    class PlayInfo
    {
        private Point point;
        private int currentPlayer;
        private Image symbol;

        public Point Point { get => point; set => point = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public Image Symbol { get => symbol; set => symbol = value; }

        public PlayInfo()
        {

        }

        public PlayInfo(Point point, int currentPlayer, Image symbol)
        {
            this.Point = point;
            this.CurrentPlayer = currentPlayer;
            this.Symbol = symbol;
        }
    }
}
