using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumLINQ.Models
{
    class Aquariums
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public int? AquariumAquaticLifeId { get; set; }
        public AquariumAquaticLife AquariumAquaticLife { get; set; }
    }
}
