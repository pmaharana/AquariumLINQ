using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumLINQ.Models
{
    class AquaticLifes
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public DateTime? DateAddedToTank { get; set; }
        public bool? IsInQuarantee { get; set; }

        public int? AquariumAquaticLifeId { get; set; }
        public AquariumAquaticLife AquariumAquaticLife { get; set; }
    }
}
