using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    interface IGameLocation
    {
        int PeopleValue { get; set; }
        int PeopleMax { get; set; }
        void Update();

    }
}
