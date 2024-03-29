using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using HogwartsPotions.Models.Enums;

namespace HogwartsPotions.Models.Entities
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public int Capacity { get; set; }

        public HashSet<Student> Residents { get; set; } = new HashSet<Student>();

        public HouseType HouseType
        {
            get => HouseType;
            set => HouseType = Residents.Count > 0 ? Residents.First().HouseType : HouseType.none;
        }
    }
}
