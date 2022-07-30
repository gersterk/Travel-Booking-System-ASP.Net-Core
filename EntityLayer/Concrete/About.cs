using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]  //DATA ANNOTATION  //Key Attribute will assign IDs as Key row of the tables
        public int AboutID { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Image1 { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public bool Status { get; set; }
        //To do not delete through the solution every moment--helps to just passivate 
    }
}
