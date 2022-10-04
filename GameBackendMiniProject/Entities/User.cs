using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string IdentityNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
    }
}
