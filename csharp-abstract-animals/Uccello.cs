﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    class Uccello : IVolatile
    {
        public void Vola()
        {
            Console.Write("sto volando!!!");
        }
    }

}
