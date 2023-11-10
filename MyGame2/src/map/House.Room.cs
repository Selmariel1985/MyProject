using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesMy
{
   

    public partial class House

    {
        private int CalcuteRoomIndex(int c , int r)
        {

            return Math.Clamp(c, -1, Width) + (Math.Clamp(r, -1, Height) * Width);

        }
        public void CreateRooms( int width, int height)
        { 
            Width = Math.Clamp(Width, 2, max: 10);
            Height = Math.Clamp(Height, 2, max: 10);
            var total = Width * Height;
            Rooms = new Room[total];

            for (var i = 0; i < total; i++)
            {
                var tmpRoom = new Room();
                var c = i % Width;
                var r = i / Height;
                tmpRoom.Name = String.Format(Text.Language.DefaultRoomName  ,i, c, r);

                if (c < Width - 1)
                {

                    tmpRoom.Neighbors[Directions.Восток] = CalcuteRoomIndex(c + 1, r);

                }
                if (c > 0)
                {

                    tmpRoom.Neighbors[Directions.Запад] = CalcuteRoomIndex(c - 1, r);

                }
                if (r < Height - 1)
                {

                    tmpRoom.Neighbors[Directions.Юг] = CalcuteRoomIndex(c, r + 1);

                }
                if (r > 0)
                {

                    tmpRoom.Neighbors[Directions.Север] = CalcuteRoomIndex(c, r - 1);

                }
                Rooms[i] = tmpRoom;
            }

        }

    }

}
