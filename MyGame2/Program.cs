using static System.Net.Mime.MediaTypeNames;
using System.Numerics;
using System;

namespace GamesMy
{
    public class Program
    {
        static void Main(string[] args)
        {

            Text.LoadLanguage(new English());


            Console.WriteLine(Text.Language.ChoseYourName);
            var name = Console.ReadLine();
            if (name == String.Empty)
            {
                name = Text.Language.DefaultName;
            }

            var player = new Player(name);
            Console.WriteLine($"{Text.Language.Wellcome}: {player.Name}");

            var house = new House(player);
            house.CreateRooms(3, 3);
            house.DecorateRooms();
            var items = new List<Item>()
            {
                new Key(house),
                new Chest(new[]{new Gold(100)}, house)
            };

            house.PopulateRooms(items);


            Actions.Instance.Register(new Go(house));
            Actions.Instance.Register(new Backpack(player));
            Actions.Instance.Register(new Take(house));
            Actions.Instance.Register(new Use(house));


            house.GoToStartingRoom();

            

            var run = true;
            Room lastRoom = null;
            while (run)
            {
                if (lastRoom != house.CurrentRoom)
                {
                    Console.WriteLine(house.CurrentRoom.ToString());
                    lastRoom = house.CurrentRoom;
                }
                Console.WriteLine(Text.Language.WhatToDo);
                var input = Console.ReadLine().ToLower();
                if (input == Text.Language.Quit)
                    run = false;
                else
                    Actions.Instance.Execute(input.Split(" "));


            }




           

        }
    }
}
