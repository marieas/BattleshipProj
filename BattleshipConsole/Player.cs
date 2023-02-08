using BattleshipConsole;
using BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship;

    internal class Player : PlayerInfoModel
    {
        public Player() : base(false)
        {          
            UserName = Messages.AskForUsersName();
            InitializeGrid();
        }
    }

