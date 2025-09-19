
namespace Grocery.Core.Models
{
    public partial class Client(int id, string name, string emailAddress, string password) : Model(id, name)
    {
        private string _emailAddress = emailAddress;
        private string _password = password;
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        public string Password { 
            get { return _password; } 
            set { _password = value; }
        }
    }
}
