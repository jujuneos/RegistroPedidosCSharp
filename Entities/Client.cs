using System;

namespace Projeto3
{
    class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birth { get; set; }

        public Client()
        {
        }

        public Client(string Name, string Email, DateTime Birth)
        {
            name = Name;
            email = Email;
            birth = Birth;
        }

        public override string ToString()
        {
            return name
                + " ("
                + birth.ToString("dd/MM/yyyy")
                + ") - "
                + email;
        }

    }
}