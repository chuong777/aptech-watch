using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;

namespace TestDataAccess.Utils
{
    public class MyDbInitializer : DropCreateDatabaseIfModelChanges<MVCDbContext>
    {
        private List<User> _users;
        private List<Author> _authors;
        private List<Category> _categories;
        private List<Tag> _tags;
        private List<BookTag> _bookTags;
        private List<Book> _books;
        private List<Discount> _discounts;
        private List<View> _views;

        protected override void Seed(MVCDbContext context)
        {
            InitUser(context);
            InitCategory(context);
            InitAuthor(context);
            InitTag(context);
            InitBook(context);
            InitBookTag(context);
            InitDiscount(context);
            InitView(context);

//            base.Seed(context);
        }

        private void InitTag(MVCDbContext context)
        {
            _tags = new List<Tag>
            {
                new Tag("English"),
                new Tag("Vietnamese")
            };
            _tags.ForEach(i => context.Tags.Add(i));
            context.SaveChanges();
        }

        private void InitUser(MVCDbContext context)
        {
            _users = new List<User>
            {
                new User("nhc", "chuong", "Chuong Nguyen"),
                new User("toilachuong", "chuong", "Nguyen Hoang Chuong")
            };
            _users.ForEach(i => context.Users.Add(i));
            context.SaveChanges();
        }

        private void InitCategory(MVCDbContext context)
        {
            _categories = new List<Category>
            {
                new Category("Fiction"),
                new Category("Adventure")
            };
            _categories.ForEach(i => context.Categories.Add(i));
            context.SaveChanges();
        }

        private void InitAuthor(MVCDbContext context)
        {
            _authors = new List<Author>
            {
                new Author("J.K", new DateTime(1987, 12, 1)),
                new Author("To Hoai", new DateTime(1867, 3, 12))
            };
            _authors.ForEach(i => context.Authors.Add(i));
            context.SaveChanges();
        }

        private void InitBook(MVCDbContext context)
        {
            _books = new List<Book>
            {
                new Book("Harry Potter", 12, _authors[0], "Harry Potter description", 1002, new DateTime(2005, 12, 22),
                    _categories[0], 200, "book1.png"),
                new Book("Chi Pheo", 12, _authors[1], "Chi Pheo description", 388, new DateTime(2000, 5, 22),
                    _categories[0], 30, "book1.png")
            };
            _books.ForEach(i => context.Books.Add(i));
            context.SaveChanges();
        }

        private void InitBookTag(MVCDbContext context)
        {
            _bookTags = new List<BookTag>
            {
                new BookTag(_books[0], _tags[0]),
                new BookTag(_books[1], _tags[1])
            };
            _bookTags.ForEach(i => context.BookTags.Add(i));
            context.SaveChanges();
        }

        private void InitDiscount(MVCDbContext context)
        {
            _discounts = new List<Discount>
            {
                new Discount(_books[0], 11, new DateTime(2016, 4, 20), new DateTime(2016, 5, 30))
            };
            _discounts.ForEach(i => context.Discounts.Add(i));
            context.SaveChanges();
        }

        private void InitView(MVCDbContext context)
        {
            _views = new List<View>
            {
                new View(_users[0], _books[0], DateTime.Now),
            };
            _views.ForEach(i => C.ViewService.Add(i));
        }
    }
}