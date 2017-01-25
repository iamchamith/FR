using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.Domin
{
    public class Faces
    {
        [Key]
        public int FaceId { get; set; }
        public string ImageName { get; set; }
        [Required]
        public string Nic { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public string _64BaseImage { get; set; }
        [NotMapped]
        public Enums.EAlgo Algo { get; set; }
    }
}
