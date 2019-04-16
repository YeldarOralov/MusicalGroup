using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalGroup.Models
{
    public class Song:Entity
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public double Rating { get; set; }
    }
}
