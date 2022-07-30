using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) // allows us to figure the context. modifies options...
        {

            optionBuilder.UseSqlServer("server=DESKTOP-TLTN1FO; database = TraversalDB; integrated security = true; "); 

        }


        //To engage the entities to sql

        public DbSet<About> Abouts { get; set; }  //to achive Dbsets, need to use Entitylayer Concrete... Abouts(the names) are tables name in SQL
        public DbSet<About2> About2s { get; set; } 
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }  
        public DbSet<Feature2> Feature2s { get; set; }  
        public DbSet<Guide> Guides { get; set; }  
        public DbSet<Testimonial> Testimonials { get; set; } 
        public DbSet<SubAbout> SubAbouts { get; set; }

    }
}
