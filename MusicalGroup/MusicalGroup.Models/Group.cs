using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalGroup.Models
{
    public class Group:Entity
    {
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }         
    }
}
