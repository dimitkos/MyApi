using Microsoft.AspNetCore.Mvc;
using WebServer.Models;
using System.Linq;
//otan theloume na kanoume query to data sources xrhsimopoioume thn linq 

namespace WebServer.Controllers
{

    [Route("api/people")]
    //ftiaxnoume ton controller
    public class PeopleController:Controller
    {

        //get all people
        [HttpGet]
        public Person[] Get()
        {
            //epistrefei ws array olous tou people
            return Repository.People.ToArray();
        }
    

        //get person by id
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return Repository.GetPersonByID(id);
        }

        //create a new person 
        [HttpPost]
        public void Post([FromBody]Person person)
        {
            Repository.AddPerson(person);
        }

        //replace existing person 
        [HttpPut("{id}")]
        public void Put(int id,[FromBody]Person person)
        {
            Repository.ReplacePersonByID(id,person);
        }

        //delete an existing person 
        [HttpDelete("{id}")]
        public void Delete(int id )
        {
            Repository.RemovePersonByID(id);
        }


    }
}