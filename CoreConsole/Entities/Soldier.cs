using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsole.Entities
{
    public class Soldier
    {
        public int MaxMorale { get; set;}
        public int Morale { get; set; }
        public int MaxToughness{ get; set; }
        public int Toughness { get; set; }

        /// <summary>
        /// Base constructor
        /// </summary>
        Soldier() {
            this.MaxMorale = 100;
            this.Morale = 100;
            this.MaxToughness = 50;
            this.Toughness = 50;
        }

        /// <summary>
        /// Dynamic constructor A
        /// </summary>
        /// <param name="newMaxMorale"></param>
        /// <param name="newMaxToughness"></param>
        Soldier(int newMaxMorale, int newMaxToughness) {
            this.MaxToughness = newMaxMorale;
            this.Morale = newMaxMorale;
            this.MaxToughness = newMaxToughness;
            this.Toughness = newMaxToughness;
        }

        /// <summary>
        /// Dynamic constructor B
        /// </summary>
        /// <param name="newMaxMorale"></param>
        /// <param name="newMaxToughness"></param>
        /// <param name="newMorale"></param>
        /// <param name="newToughness"></param>
        Soldier(int newMaxMorale, int newMaxToughness, int newMorale, int newToughness) {
            this.MaxMorale = newMaxMorale;
            this.Morale = newMorale;
            this.MaxToughness = newMaxToughness;
            this.Toughness = newToughness;
        }
    }
}
