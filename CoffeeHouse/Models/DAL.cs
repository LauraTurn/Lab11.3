using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace CoffeeHouse.Models
{
    public class DAL
    {
        public static IDbConnection db;

        //Add CRUD operations.


        //Read - This operation reads all of the categories
        public static List<String> ReadAllCategories()
        {

            return db.Query<String>($"select distinct category from product;").ToList();

            //return db.GetAll<Category>().ToList();
            //return db.Query<Product>($"select distinct category from product order by category").ToList();
        }

        
        //Read - This reads a single cagetory
        public static List<Product> ReadOneCategory(string category)
        {

            return db.Query<Product>($"select category from product where category = '{category}';").ToList();

            //return db.Get<Category>(id);
        }

        //Read - This lists the product in the category
        public static List<Product> ReadProductsInCategory(string category)
        {
            List<Product> test = db.Query<Product>($"select * from product where category = '{category}'").ToList();
            return test;

            //category = "Coffee";
            //List<Product> AllProducts = db.GetAll<Product>().ToList()
            //return db.Query<Product>($"select * from product where category = '{category}';").ToList();
        }


        //ADMIN CONTROLLER FUNCTIONS
        //Reads: Lists all of the products
        public static List<Product> ReadAllProducts()
        {
            return db.GetAll<Product>().ToList();
            
        }

        //Reads: Lists one product
        public static Product GetSingleProduct(int id)
        {
            return db.Get<Product>(id);
        }

        //Create: Adds a product to the database
        public static void AddProduct (Product produce)
        {
            db.Insert(produce);
        }

        //Delete: Remove Product from List by ID
        static public void Delete(int id)
        {
            Product produce = new Product();
            produce.id = id;
            db.Delete<Product>(produce);
        }


        //Update: Edit an existing Product
        public static void EditProduct(Product produce)
        {
            db.Update(produce);
        }
    }
}
