﻿using MyAirport.Pim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Models
{
    public class Natif : AbstractDefinition
    {
        public override Entities.BagageDefinition GetBagage(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override List<Entities.BagageDefinition> GetBagage(string codeIataBagage)
        {
            List<BagageDefinition> list = new List<BagageDefinition>();
            Console.WriteLine(codeIataBagage);
            return list;
        }
    }
}

