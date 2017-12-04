using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsole.Entities {

    public class Person {

        public string ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }

        public Person(string newFirstName, string newLastName, string newMiddleName = null)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            
            if (string.IsNullOrEmpty(newMiddleName)) {
                this.MiddleName = null;
            }
            else {
                this.MiddleName = newMiddleName;
            }
        }

        public string FullName() {
            return this.FirstName + " " + (string.IsNullOrEmpty(this.MiddleName) ? "" : this.MiddleName + " ") + this.LastName;
        }
    }
}
