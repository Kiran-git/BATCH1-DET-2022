using BATCH1_DET_2022.Data;
using BATCH1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    public class CodefirstApproch
    {
       public static void Main(string[] args)
        {
            //  AddNewBook();
            // RemoveBook();
            //   Update();
            //getAllBookDetailsByID();
            // Console.ReadLine();
            //  AddnewcustomerAndOrder();
            //AddnewcustomerAndOrder();
            //GetAllCustomersWithOrder_EagerLoading();
            //  GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();

        }
        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 1;
        //    book.BookName = "EF core";
        //    book.author = "jack";
        //    book.price = 100;

        //    var ctxx = new BookContext();
        //    Book boook = new Book();
        //    book.BookID = 2;
        //    book.BookName = "wings of fire";
        //    book.author = "APJ";
        //    book.price = 500;

        //    var ctx2 = new BookContext();
        //    Book book2 = new Book();
        //    book.BookID = 3;
        //    book.BookName = "wings";
        //    book.author = "king";
        //    book.price = 500;


        //    try
        //    {
        //        ctx.Books.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("add book added successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void RemoveBook()
        //     {
        //    var ctx = new BookContext();
        //Book book = new Book();
        //book.BookID = 1;
        //    book.BookName = "EF core";
        //    book.author = "jack";
        //    book.price = 100;

        //    var ctxx = new BookContext();
        //Book boook = new Book();
        //book.BookID = 2;
        //    book.BookName = "wings of fire";
        //    book.author = "APJ";
        //    book.price = 500;


        //    try
        //    {
        //        ctx.Books.Remove(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Remove book added successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void Update()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 1;
        //    book.BookName = "EF core";
        //    book.author = "jack";
        //    book.price = 100;

        //    var ctxx = new BookContext();
        //    Book boook = new Book();
        //    book.BookID = 2;
        //    book.BookName = "wings of fire";
        //    book.author = "apj";
        //    book.price = 500;


        //    try
        //    {
        //        ctx.Books.Update(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("update book added successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //public static void getAllBookDetailsByID()
        //{
        //    var ctx = new BookContext();
        //    var book = ctx.Books;

        //    foreach (var e in book)
        //    {
        //        Console.WriteLine(e.BookName);
        //    }
        //}


        private static void AddnewcustomerAndOrder()
        {
            var ctx = new BookContext();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "sheela";
            customer.Age = 45;

            Order ord = new Order();
            ord.Order_ID = 100;
            ord.Amount = 2000;
            ord.OrderDate = DateTime.Now;

            ord.cust = customer;
            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("custmer and order is created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString()) ;
            }

        }

        private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded 
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");

                //var customers = ctx.Customers.Include(o => o.Orders);                   

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }


        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }
    }

}
