using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using AptechWatch.Entity;

namespace AptechWatch.Utils
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext() : base("DefaultConnectionString")
        {
        }


        public DbSet<Brand> Brands { get; set; }
        public DbSet<Watch> Watches { get; set; }
        public DbSet<News> Newses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ViewList> ViewLists { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PhotoUrl> PhotoUrls { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<WatchTag> WatchTags { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<T> GetRightDbSet<T>() where T : BaseEntity
        {
            if (typeof(T) == typeof(Brand))
            {
                return Brands as DbSet<T>;
            }
            if (typeof(T) == typeof(Watch))
            {
                return Watches as DbSet<T>;
            }
            if (typeof(T) == typeof(News))
            {
                return Newses as DbSet<T>;
            }
            if (typeof(T) == typeof(Admin))
            {
                return Admins as DbSet<T>;
            }
            if (typeof(T) == typeof(Chat))
            {
                return Chats as DbSet<T>;
            }
            if (typeof(T) == typeof(Message))
            {
                return Messages as DbSet<T>;
            }
            if (typeof(T) == typeof(Cart))
            {
                return Carts as DbSet<T>;
            }
            if (typeof(T) == typeof(Customer))
            {
                return Customers as DbSet<T>;
            }
            if (typeof(T) == typeof(ViewList))
            {
                return ViewLists as DbSet<T>;
            }
            if (typeof(T) == typeof(WishList))
            {
                return WishLists as DbSet<T>;
            }
            if (typeof(T) == typeof(PhotoUrl))
            {
                return PhotoUrls as DbSet<T>;
            }
            if (typeof(T) == typeof(Comment))
            {
                return Comments as DbSet<T>;
            }
            if (typeof(T) == typeof(Tag))
            {
                return Tags as DbSet<T>;
            }
            if (typeof(T) == typeof(WatchTag))
            {
                return WatchTags as DbSet<T>;
            }
            if (typeof(T) == typeof(Discount))
            {
                return Discounts as DbSet<T>;
            }
            if (typeof(T) == typeof(Category))
            {
                return Categories as DbSet<T>;
            }
            if (typeof(T) == typeof(Order))
            {
                return Orders as DbSet<T>;
            }
            if (typeof(T) == typeof(OrderDetail))
            {
                return OrderDetails as DbSet<T>;
            }
            throw new System.Exception("Please update MVCDbContext.GetRightDbSet");
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}