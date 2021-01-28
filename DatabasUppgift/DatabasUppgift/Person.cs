using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasUppgift
{
    public class Person
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public string Adress { get; protected set; }
        public string Phonenumber { get; protected set; }
        public string Mail { get; protected set; }

        public int Id { get; protected set; }


        public Person(string firstName, string lastName, string adress, string phonenumber, string mail, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            Phonenumber = phonenumber;
            Mail = mail;
            Id = id;
        }

        public virtual string GetString()
        {
            return "Name: " + FirstName + " " + LastName + "\n" +
                "Adress: " + Adress + "\n" +
                "Phonenumber: " + Phonenumber + "\n" +
                "Mail: " + Mail;
        }
    }
}
