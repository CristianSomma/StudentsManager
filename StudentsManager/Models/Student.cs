using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace StudentsManager.Models
{
    public class Student
    {
        private string _name, _surname;
        private string _code;
        private string _class;

        public Student()
        {
            _name = "UNKNOWN";
            _surname = "UNKNOWN";
            _code = "XX-00000";
            _class = "0°XX";
        }

        public Student(
            string name, 
            string surname, 
            string code, 
            string @class)
        {
            Name = name;
            Surname = surname;
            Code = code;
            Class = @class;
        }

        public string FullName => $"{Name} {Surname}";

        public string Name
        {
            get => _name;
            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(value);

                _name = value.ToUpper();
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(value);

                _surname = value.ToUpper();
            }
        }

        public string Code
        {
            get => _code;
            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(value);

                _code = value.ToUpper();
            }
        }

        public string Class
        {
            get => _class;
            set
            {
                ArgumentNullException.ThrowIfNullOrWhiteSpace(value);

                _class = value.ToUpper();
            }
        }
    }
}
