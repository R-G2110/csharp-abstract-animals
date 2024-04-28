﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    class Passerotto : Animale, IVolante
    {
        public override void Verso()
        {
            Console.Write("cip-cip");
        }

        public override void Mangia()
        {
            Console.Write("semi");
        }
        public void Vola()
        {
            Console.Write("volo!!!");
        }
    }
}
