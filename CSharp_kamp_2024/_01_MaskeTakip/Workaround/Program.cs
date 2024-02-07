using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.NationalIdentity = 12345678910;
            person.FirstName = "Abdullah";
            person.LastName = "Şentürk";
            person.DateOfBirthYear = 1982;
            
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
        }
    }
}
