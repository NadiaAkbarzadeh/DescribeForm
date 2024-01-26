using DescribeForm.Models;
using DescribeForm.Repositories.Interface;
using System;

namespace DescribeForm.Repositories.Implementation
{
    public class DescribeRepository : IDescribeRepository
    {
        private readonly ApplicationDbContext db;

        public DescribeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int CreateDescribe(Describe describe)
        {
            db.Describes.Add(describe);  
            db.SaveChanges();
            return describe.Id;

        }
        public List<Describe> GetAll()
        {
          return  db.Describes.ToList();
        }
        public Describe GetDescribeById(int id)
        {
            return db.Describes.Single(x => x.Id == id);
        }

        public void Update(Describe describe)
        {

            db.Entry(describe).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();   
        }
        public void Remove(int id)
        {
            var describe = GetDescribeById(id);
            db.Describes.Remove(describe);
            db.SaveChanges();

        }

     
    }
}
