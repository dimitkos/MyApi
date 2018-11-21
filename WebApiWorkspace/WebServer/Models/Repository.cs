using System.Collections.Generic;
using System.Linq;

namespace WebServer.Models
{
    public class Repository
    {
        //ftiaxnoume kai mia statikh metavlith gia na kratame ton arithmo twn anthrwpwn
        //einai static giati anhkeis thn klassh
        private static int counter;

        //ftiaxnoume mia lista opou tha pernei antikeimena typou person
        public static IList<Person> People {get;} = new List<Person>();

        //methodos opoy mas epistrefei ena person kanwntas pass to id
        public static Person GetPersonByID(int id)
        {

            //einai methodos singleordefault h opoia an brei ena stoixeio ths dinei mia tihmh alliws pernei default
            var target = People.SingleOrDefault(p => p.ID == id);
            return target;
        }

        //  mporoume na kanoume delete persons h people apo to repository kanwntas pass sta arguments to id 
        public static void RemovePersonByID(int id)
        {
            var target = People.SingleOrDefault(p => p.ID == id);
            //KANOUME ENAN ELEGXO  oti exoume to target
            if(target !=null)
            {
                //an yparxei to target to kanoume remove 
                People.Remove(target);
            }
        }

        //methodos h opoia mas epitrepei na kanoume update tis plirofories vasizomeno sto id kai apo to object typou person
        public static void ReplacePersonByID(int id,Person person)
        {
            var target = People.SingleOrDefault(p => p.ID == id);
            //KANOUME ENAN ELEGXO  oti exoume to target
            if(target !=null)
            {
                //an yparxei to target to kanoume remove 
                People.Remove(target);
                //sthn synexeia kanoume add to object people
                People.Add(person);

            }
        }

//kanoume add ena neo people
        public static void AddPerson(Person person)
        {
            //ayksanoume ton metrhth kata ena
            person.ID = counter++;
            //sthn synexeia to object to topothetoume mesa sthn lista mas
            People.Add(person);
        }
    }
}