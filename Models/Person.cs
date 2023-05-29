using System.Collections.Generic;

namespace Knockout_Asp.NetMVC_1.Controllers
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Friend> Friends { get; set; }
    }
}