using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class GenericCollections
    {
        public List<int> Numbers = new List<int>();
        public List<string> Names = new List<string>();    
        public List<Person> Persons = new List<Person>();

        public void AddNumber(int num)
        {
            Numbers.Add(num);
        }
        public void AddName(string name)
        {
            Names.Add(name);
        }
        public void RemoveNumber(int number)
        {
            if (Numbers.Contains(number))
            {
                Numbers.Remove(number);
                Console.WriteLine($"{number} is removed from the list");
            }
            else Console.WriteLine("Number does not exist in the list.");
        }
        public void RemoveName(string name)
        {
            if (Names.Contains(name))
            {
                Names.Remove(name);
                Console.WriteLine($"{name} is removed from the list.");
            }
                
            else Console.WriteLine("Name does not exist in the list.");
        }
        public void RemovePersons(string id)
        {
            Persons.RemoveAll(p => p.ID == id); 
        }
        public void DisplayNumbers()
        {
            foreach(var num in  Numbers){
                Console.Write(Numbers + " ");
            }
        }
        public void DisplayNames()
        {
            foreach(var name in Names)
            {
                Console.Write(name + " ");  
            }
        }
        public void DisplayPersons()
        {
            foreach (var person in Persons)
            {
                // DisplayPersonInfo returns void, so just call it without Console.WriteLine
                person.DisplayPersonInfo();
            }
        }
        public void GetPersonsWithID(string id)
        {
            foreach(var person in Persons)
            {
                if(id == person.ID)
                {
                    Console.WriteLine($"Person name {person.name}, age : {person.age} and city: {person.city}");
                    return;
                }
            }
            Console.WriteLine("Person with the given id not found");
        }
    }
}
