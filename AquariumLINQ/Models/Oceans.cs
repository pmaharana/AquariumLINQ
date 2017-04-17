using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumLINQ.Models
{
    class Oceans
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double AverageTemperature { get; set; }

        public int? AquariumAquaticLifeId { get; set; }
        public AquariumAquaticLife AquariumAquaticLife { get; set; }
    }
}
