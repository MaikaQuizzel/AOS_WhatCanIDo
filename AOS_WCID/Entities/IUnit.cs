using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public interface IUnit:IModels
    {
        List<Attack> Attacks();
        int Move();
        int Save();
        int Bravery();
        int Wounds();
        int Size();
        int Points();
        
    }
}
