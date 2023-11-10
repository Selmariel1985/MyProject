using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesMy
{
    public class Key : Item
    {
        private readonly House _house;

        public Key(House house)
        {

            _house = house;
            CanTake = true;
            SingleUse = true;

        }
        public override string Name { get; set; } = Text.Language.Key;

        public override void Use(string source)
        {
            _house.CurrentRoom.Use(Text.Language.Chest, Name);
        }
    }

}
