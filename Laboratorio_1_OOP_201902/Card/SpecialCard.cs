using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class SpecialCard:Card
    {
        //Atributos
        private string buffType;
        private bool captain;

        //Constructor
        public SpecialCard(string name, string type, string effect, bool captain):base(name, type, effect)
        {
            Name = name;
            Type = type;
            Effect = effect;
            BuffType = null;
            this.captain = captain;
        }

        //Propiedades
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }
        }

    }
}
