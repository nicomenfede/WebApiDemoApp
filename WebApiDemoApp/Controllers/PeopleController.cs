using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemoApp.Models;

namespace WebApiDemoApp.Controllers
{
    /// <summary>
    /// This is where you get the information of my peeps
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { Id = 1, FisrtName = "Tim", LastName = "Corey"});
            people.Add(new Person { Id = 2, FisrtName = "Sue", LastName = "Storm" });
            people.Add(new Person { Id = 3, FisrtName = "Bilbo", LastName = "Baggins" });
        }

        /// <summary>
        /// Get's the names of all the people
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        [Route("api/People/GetNames/{userid:int}/{age:int}")]
        [HttpGet]
        public List<string> GetNames(int userid, int age)
        {
            List<string> nameList = new List<string>();

            foreach (var p in people)
            {
                nameList.Add(p.FisrtName);
            }
            return nameList;
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
