using GamesMy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesMy
{ 
    public partial class House
    {
        public void DecorateRooms()
        {
            foreach (var room in Rooms)
            {
                var roomDescription = Text.Language.RooomDescriptions[0];
                if (Text.Language.RooomDescriptions.Count > 1 && _rnd.Next(0 , 2) == 1)
                {
                    roomDescription = Text.Language.RooomDescriptions[_rnd.Next(1,
                        Text.Language.RooomDescriptions.Count)];
                    Text.Language.RooomDescriptions.Remove(roomDescription);
                }
                room.Description = String.Format(Text.Language.DefaultRoomDescriptions,
                    roomDescription, "{0}");

            }
        }

        public void PopulateRooms(List<Item> items)
        {
            var i = 0;
            while (i != items.Count)
            {
                var room = Rooms[_rnd.Next(0 , Rooms.Length)];

                if (room.Total == 0)
                {
                    room.Add(items[i]);
                    i++;
                }
            }
        }

    }
}
