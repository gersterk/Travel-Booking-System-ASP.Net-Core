using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Little About Descriptions -- I love it, Im gonna keep it :))


namespace EntityLayer.Concrete
{
    public class SubAbout
    {
        [Key]  //DATA ANNOTATION  //Key Attribute will assign IDs as Key row of the tables
        public int SubAboutID { get; set; }
        public string Title { get; set; }   
        public string Description { get; set; }   


    }

}
