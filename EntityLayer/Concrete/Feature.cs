using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This is the part of Home/BIG Images
//Respectively shows the images 
//With the entities below


namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]  //DATA ANNOTATION  //Key Attribute will assign IDs as Key row of the tables
        public int FeatureID { get; set; }
        public string Post1Name { get; set; }    
        public string Post1Description { get; set; }    
        public string Post1Image { get; set; }    
        public bool Post1Status { get; set; }    

    }
}
