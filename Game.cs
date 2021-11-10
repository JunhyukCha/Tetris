using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
    class Game
    {
        Diagram now;
        internal Point NowPosition
        {
            get
            {
                if (now == null)
                {
                    return new Point(0, 0);
                }
                return new Point(now.X, now.Y);
            }
        }

        internal static Game Singleton
        {
            get;
            private set;
        }

        //여기 static Game이 굳이 필요한지
        static Game()
        {
            Singleton = new Game();
        }

        Game()
        {
            now = new Diagram();
        }

        internal bool MoveLeft()
        {
            if(now.X > 0)
            {
                now.MoveLeft();
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool MoveRight()
        {
            if (now.X + 1 < GameRule.BX)
            {
                now.MoveRight();
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool MoveDown()
        {
            if (now.Y+1 < GameRule.BY)
            {
                now.MoveDown();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Game()
        //{
        //    now = new Game();
        //}
    }
}
