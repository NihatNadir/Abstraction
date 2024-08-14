using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstraction
{
    abstract class Employee // Abstract sınıfı
    {
        private string _name; // _name field
        private string _surName; // _surName field
        private string _departman; // _departman field
        public string Name // Name property
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string SurName // SurName property
        {
            get
            {
                return _surName;
            }
            set
            {
                _surName = value;
            }
        }

        public string Departman // Departman property
        {
            get
            {
                return _departman;
            }
            set
            {
                _departman = value;
            }
        }

        public abstract void Mission(); // Abstract metodu

    }

    class SoftwareDeveloper : Employee // Çalışanın mesleğini gireceği class
    {

        public override void Mission()
        {

            Departman = Console.ReadLine() ?? ""; // Nesnenin bilgilerini konsoldan giriyoruz.
            Console.WriteLine($"{Name} {SurName} {Departman} olarak çalışıyorsunuz.");
        }
    }

    class ProjectManager : Employee // Çalışanın mesleğini gireceği class
    {

        public override void Mission()
        {

            Departman = Console.ReadLine() ?? ""; // Nesnenin bilgilerini konsoldan giriyoruz.
            Console.WriteLine($"{Name} {SurName} {Departman} olarak çalışıyorsunuz.");
        }
    }



}
