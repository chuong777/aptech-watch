using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using AptechWatch.Service;

namespace AptechWatch.Utils
{
    public class C
    {
        public static MVCDbContext DbContext = new MVCDbContext();
        public static AdminService AdminService = new AdminService();
        public static BrandService BrandService = new BrandService();
        public static CartService CartService = new CartService();
        public static CategoryService CategoryService = new CategoryService();
        public static ChatService ChatService = new ChatService();
        public static CommentService CommentService = new CommentService();
        public static CustomerService CustomerService = new CustomerService();
        public static DiscountService DiscountService = new DiscountService();
        public static MessageService MessageService = new MessageService();
        public static NewsService NewsService = new NewsService();
        public static OrderDetailService OrderDetailService = new OrderDetailService();
        public static OrderService OrderService = new OrderService();
        public static PhotoUrlService PhotoUrlService = new PhotoUrlService();
        public static TagService TagService = new TagService();
        public static ViewListService ViewListService = new ViewListService();
        public static WatchService WatchService = new WatchService();
        public static WatchTagService WatchTagService = new WatchTagService();
        public static WishListService WishListService = new WishListService();
    }
}