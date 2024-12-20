using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
           

            //Department d1 = new Department(1,"Computers");
            //Department d2 = new Department(2,"Books");
            //Department d3 = new Department(3,"Tools");
            //Department d4 = new Department(4,"Shoes");


            //Seller s1 = new Seller(1,"Bob, the Fool", "bobthefool@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            //Seller s2 = new Seller(2, "Bob, the Cool", "bobthefool@gmail.com", new DateTime(1998, 4, 21), 1000.0, d2);
            //Seller s3 = new Seller(3, "Bob, the Wool", "bobthefool@gmail.com", new DateTime(1998, 4, 21), 1000.0, d3);
            //Seller s4 = new Seller(4, "Bob, the Cruel", "bobthefool@gmail.com", new DateTime(1998, 4, 21), 1000.0, d4);

            //SalesRecord r1 = new SalesRecord(1,new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s1);

            //_context.Department.AddRange(d1, d2, d3, d4);
            //_context.Seller.AddRange(s1,s2,s3,s4);  
            //_context.SalesRecord.Add(r1);

            //_context.SaveChanges();
        }
    }
}
