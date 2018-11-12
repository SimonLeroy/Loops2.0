using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region boucles
            //for
            //Console.WriteLine("---------------------For--------------------------------");
            //List<string> stagiairesList = new List<string>();
            //stagiairesList.AddRange(new string[] { "Pauline", "Nathalie", "Amine", "Jonathan", "Johann", "Fatima", "Marion", "Chloé", "Narimane", "Nabil"});

            //for (int i = 0; i < stagiairesList.Count; i++)
            //{

            //    Console.WriteLine(i +" "+ stagiairesList[i]);


            //}
            //Console.WriteLine("---------------------Foreach classique------------------");
            ////foreach
            //foreach (string stagiaire in stagiairesList)
            //{
            //    Console.WriteLine(stagiaire);
            //}

            //Console.WriteLine("--------------------Foreach Linq-----------------------");

            //stagiairesList.ForEach(x => Console.WriteLine(x));

            //Console.WriteLine("--------------------While-----------------------");
            //int n = 0;
            //while (n < 5)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}
            //Console.WriteLine("---------------------Switch--------------------------------");
            //foreach (string stagiaire in stagiairesList)
            //{
            //    int letterNumber = stagiaire.Count();

            //    switch (letterNumber)
            //    {
            //        case 5:
            //            Console.WriteLine(stagiaire + " j ai 5 lettres à mon prénom");
            //            break;
            //        case 6 :
            //            Console.WriteLine(stagiaire + " j ai 6 lettres à mon prénom");           
            //           break;
            //        default:
            //            Console.WriteLine(stagiaire + " Mon nombre de lettre ne rentre pas dans les conditions du switch :-(");
            //            break;

            //    }
            //}

            ////Methode  pour arrondir à la superieur lui confier le résultat
            //Console.WriteLine(Math.Ceiling(12.51));
            //int? t = null;

            //Console.WriteLine(t);
            #endregion

            #region linq
            //Test sur Linq
            Console.WriteLine("-------------Test Linq---------");
            Stagiaire stagiaire = new Stagiaire();
            Room room = new Room();
            Teacher teacher = new Teacher();
            var listStagiaires = stagiaire.GetStagiairesList();
            var listRoom = room.GetRooms();
            var listTeacher = teacher.GetTeachers();
          
            var  stagiaires = listStagiaires.Where(x => x.Prenom.Contains("Marion")).FirstOrDefault();

            // sortie de tous les noms de stagiaires qui ont l'id teacher à deux
            var s = from stag in listStagiaires
                    join t in listTeacher on stag.Id_Teacher equals t.Id_teacher
                    where stag.Id_Teacher == 2
                    select stag;

            s.ToList().ForEach(x => Console.WriteLine(x));

            //sortie de tous les teachers frequentant la salle deux
            var tea = from teach in listTeacher
                      join roo in listRoom on teach.Id_room equals roo.Id_room
                      where roo.Id_room == 2
                      select teach;

            tea.ToList().ForEach(x => Console.WriteLine(x));


                      #endregion
            Console.ReadKey();
        }
    }
}











