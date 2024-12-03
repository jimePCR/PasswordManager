using System.Collections.Generic;

namespace PassMan
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MasterPass { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
