using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int StylistId { get; set; }
        public string Name { get; set; }
        public virtual Stylist Stylist { get; set; }
    }
}