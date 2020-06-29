using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemoApp.Models
{
    /// <summary>
    /// This is the information that we have about one person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// This is the person's ID
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// Fist name of the person
        /// </summary>
        public string FisrtName { get; set; } = String.Empty;

        /// <summary>
        /// Lastname of the person
        /// </summary>
        public string  LastName { get; set; } = String.Empty;
    }
}