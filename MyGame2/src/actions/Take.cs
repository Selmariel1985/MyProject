﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GamesMy
{
    public class Take : Action
    {
        private readonly House _house;

        public Take(House house)
        {
            _house = house;
        }

        public override string Name => Text.Language.Take;
        public override void Execute(string[] args)
        {
            if (args.Length == 1)
            {
                Console.WriteLine(Text.Language.NotTaken);
                return;
            }
                var inventory = _house.CurrentRoom;

                var itemNames = args[1].ToLower();
            
                if (inventory.Contains(itemNames))
                {
                    var item = inventory.Take(itemNames);
                    if (item.CanTake)
                    {
                        _house.Player.Add(item);
                        Console.WriteLine(Text.Language.TookDescription, item.Name);
                    }
                    else
                    {
                        Console.WriteLine(Text.Language.CantTakeDescription, item.Name);
                    }

                    return;

                }
                Console.WriteLine(Text.Language.TakeError);
            }
        }
    }

