using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> team1 = new arrayList<String>();
            List<String> team2 = new arrayList<String>();
            List<String> team3 = new arrayList<String>();

            team1.addAtTail("Marco");
            team1.addAtTail("Raul");
            team1.addAtTail("Ivan");
            team1.addAtTail("Anahi");

            team2.addAtFront("Juan");
            team2.addAtFront("Rita");
            team2.addAtFront("Luis");
            team2.addAtFront("Kevin");

            team3.addAtFront("Tadeo");

            Iterator<String> iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");

            //Debio haber impreso 
            //Marco
            //Raul
            //Ivan
            //Anahi

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            //Debio haber impreso 
            //Kevin
            //Luis
            //Rita
            //Juan

            team1.remove(0);
            team1.remove(2);
            team1.addAtFront("Isai");
            team1.addAtTail("Francisco");
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes ");//Debe imprimir "Team 1 tiene 4 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            //Debió haber impreso
            //Isai
            //Raul
            //Ivan
            //Francisco

            team2.remove(2);
            team2.addAtFront("Mario");
            team2.addAtTail("Imelda");
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes ");//Debe imprimir "Team 2 tiene 5 integrantes

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            //Debio haber impreso 
            //Mario
            //Kevin
            //Luis
            //Juan
            //Imelda

            team3.remove(0);
            team3.remove(0);

            team3.addAtTail("Misael");
            team3.addAtFront("Popeye");
            team3.remove(0);
            team3.addAtFront("Daniel");

            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes"); //Debe imprimir "Team 3 tiene 2 integrantes"

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Daniel
            // Misael

            if (team1.getAt(2).Equals("Ivan"))
            {
                team1.setAt(2, "Roberto");
            }

            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");//Debe imprimir "Team 1 tiene 4 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            //Debió haber impreso
            //Isai
            //Raul
            //Roberto
            //Francisco
        }
    }
}
