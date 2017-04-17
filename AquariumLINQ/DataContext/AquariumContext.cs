using AquariumLINQ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumLINQ.DataContext
{
    class AquariumContext :DbContext
    {
        public AquariumContext():base()
        {

        }

        public DbSet<AquaticLifes> AquaticLife { get; set; }
        public DbSet<Aquariums> Aquarium { get; set; }
        public DbSet<Oceans> Ocean { get; set; }
        public DbSet<AquariumAquaticLife> AquariumAquaticLife { get; set; }
    }
}
