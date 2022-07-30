using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  This part represent the below part of about section

namespace EntityLayer.Concrete
{
    public class About2
    {
        [Key]  //DATA ANNOTATION  //Key Attribute will assign IDs as Key row of the tables
        public int About2ID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }


    }
}
