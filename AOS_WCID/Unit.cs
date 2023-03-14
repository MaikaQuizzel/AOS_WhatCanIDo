using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOS_WCID.Entities;

namespace AOS_WCID
{
    public class Unit
    {
        private int size;
        private string name;
        private int movementRange;
        private List<Attack> attackList = new List<Attack>();
        private int save;
        private int bravery;
        private int wounds;
        private int points;
        private List<string> keywords = new List<string>();
        private int renown;
        private bool isGeneral = false;
        private List<Ability> abilities = new List<Ability>();

        public Unit(int size, string name, int movementRange, List<Attack> attackList, int save, int bravery, int wounds, int points, List<string> keywords, int renown, bool isGeneral, List<Ability> abilities)
        {
            this.Size = size;
            this.Name = name;
            this.MovementRange = movementRange;
            this.AttackList = attackList;
            this.Save = save;
            this.Bravery = bravery;
            this.Wounds = wounds;
            this.Points = points;
            this.Keywords = keywords;
            this.Renown = renown;
            this.IsGeneral = isGeneral;
            this.Abilities = abilities;
        }

        public int Size { get => size; set => size = value; }
        public string Name { get => name; set => name = value; }
        public int MovementRange { get => movementRange; set => movementRange = value; }
        public List<Attack> AttackList { get => attackList; set => attackList = value; }
        public int Save { get => save; set => save = value; }
        public int Bravery { get => bravery; set => bravery = value; }
        public int Wounds { get => wounds; set => wounds = value; }
        public int Points { get => points; set => points = value; }
        public List<string> Keywords { get => keywords; set => keywords = value; }
        public int Renown { get => renown; set => renown = value; }
        public bool IsGeneral { get => isGeneral; set => isGeneral = value; }
        public List<Ability> Abilities { get => abilities; set => abilities = value; }
    }
}
