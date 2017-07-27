using System;
using System.Linq;
using DotnetCore_EnityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore_EnityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();
            var dataInsert = context.Products.FromSql("usp_CreateShipper @p0, @p1",parameters: new[] { "hello", "world" });
            var p = context.Products.FromSql("usp_GetProductByName @p0","Chai").ToArray();
            foreach (var ss in p)
            {
                Console.WriteLine(ss.ProductName);
                Console.WriteLine(ss.UnitPrice);
            }
            var query = from category in context.Categories
                        select new
                        {
                            category.CategoryName
                        };
            foreach (var s in query)
            {
                Console.WriteLine(s.CategoryName);
            }
        }
    }
}
