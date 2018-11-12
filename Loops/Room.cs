using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Room
    {
        private int id_room;
        private string name;

        public int Id_room { get => id_room; set => id_room = value; }
        public string Name { get => name; set => name = value; }

        public Room() { }

        public Room(int id, string name)
        {
            Id_room = id;
            Name = name;
        }
        public override string ToString()
        {
            return "id: " + Id_room + " name: " + Name;
        }

        public List<Room> GetRooms()
        {
            var Rooms = new List<Room>();

            Rooms.Add(new Room(1, "Saturne"));
            Rooms.Add(new Room(2, "Mercure"));
                    
            return Rooms;
        }
    }
}
