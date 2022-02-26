using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveMeNow
{
    [System.Serializable]
    public class Power
    {
        public string name;
        public int value;

        public Power(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
    }

    [CreateAssetMenu(fileName = "New Superhero", menuName = "Superhero")]
    public class Superhero : ScriptableObject
    {
        public new string name;
        public List<Power> powers;
        public Sprite headShot;

        public Superhero(string name, List<Power> powers)
        {
            this.name = name;
            this.powers = powers;
        }

        public bool HasPower(string powerName)
        {
            bool retval = false;
            powers.ForEach(delegate (Power item)
            {
                retval |= item.name == powerName;
            });
            return retval;
        }
    }
}
