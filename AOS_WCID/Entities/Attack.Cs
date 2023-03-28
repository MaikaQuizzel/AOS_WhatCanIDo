using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Attack
    {
        private int _toHit;
        private int _toWound;
        private int _rend;
        private string _damage;
        private int _attackCount;
        private int _range;
        private bool _isMelee;
        private string _attackName;

        public int ToHit { get => _toHit;  }
        public int ToWound { get => _toWound;  }
        public int Rend { get => _rend; }
        public string Damage { get => _damage;  }
        public int AttackCount { get => _attackCount;  }
        public int Range { get => _range; }
        public bool IsMelee { get => _isMelee;  }
        public string AttackName { get => _attackName;  }

        public Attack(string attackName, int toHit, int toWound, int rend, string damage, int attackCount, int range, bool isMelee)
        {
            _attackName = attackName;
            _toHit = toHit;
            _toWound = toWound;
            _rend = rend;
            _damage = damage;
            _attackCount = attackCount;
            _range = range;
            _isMelee = isMelee;
        }
    }
}
