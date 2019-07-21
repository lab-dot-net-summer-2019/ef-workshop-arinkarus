using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Domain
{
    public class SamuraiDepartment
    {
        public SamuraiDepartment()
        {
            this.Samurais = new List<Samurai>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Samurai> Samurais { get; set; }
    }
}
