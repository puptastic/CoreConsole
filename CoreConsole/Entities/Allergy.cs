using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsole.Entities {

    public class Allergy {

        public string ID { get; private set; }
        public string AllergyName { get; set; }

        public Allergy(string newAllergyName) {
            this.AllergyName = newAllergyName;
        }
    }
}
