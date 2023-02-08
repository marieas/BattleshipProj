using BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship;

public class Computer : PlayerInfoModel
{
    private readonly Random r = new();
    public Computer() : base(true)
    {
        RandomName();
        InitializeGrid();
        PlaceComputerShips();
    }

    public void RandomName()
    {
        var r = new Random();
        List<string> names = new List<string>()
        {
            "Kaptein Sortebill",
            "Kaptein Sabeltann",
            "Løytnant Kabelsatan",
            "Guybrush Threepwood",
            "Captain LeChuck",
            "Simen Rødskjegg",
            "Robert Blåpels",
            "Kaptein Thomassen",
            "Fredrik Tordenbart"
        };
        UserName = names[r.Next(0, names.Count)];
    }

    public void PlaceComputerShips()
    {
        while (ShipLocations.Count < 5)
        {
            var letter = _letters[r.Next(0, _letters.Count)];
            var number = r.Next(1, 5);
            if (IsOccupied(letter, number)) continue;

            PlaceShip(letter, number);
        }
    }
}

