using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
   public class Teacher
    {
        private int id_teacher;
        private string name;
        private int id_room;
        

        public string Name { get => name; set => name = value; }
        public int Id_teacher { get => id_teacher; set => id_teacher = value; }
        public int Id_room { get => id_room; set => id_room = value; }

        public Teacher() { }

        public Teacher(int id, string name, int idRoom)
        {
            Id_teacher = id;
            Name = name;
            Id_room = idRoom;
        }
        public override string ToString()
        {
            return "id: "+ Id_teacher+ " Teacher: "+ Name + "IdRoom: "+ Id_room;
        }

        public List<Teacher> GetTeachers()
        {
            var teachers = new List<Teacher>();

            teachers.Add(new Teacher(1,"James", 1));
            teachers.Add(new Teacher(2, "Mickey", 2));
            teachers.Add(new Teacher(3, "Hassan", 2));
            teachers.Add(new Teacher(4, "Pascal", 1));

            return teachers;
        }
    }
}
