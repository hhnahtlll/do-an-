using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.ActivationContext;
using System.Web.UI.WebControls;
using NetCafe.Models;
using System.Web.UI;


// Controllers/HomeController.cs
public class HomeController : Controller
{
    private List<NetCafe.Models.MenuItem> _menuItems;

    public HomeController()
    {
        // Initialize menu items (in a real app, this would come from a database)
        _menuItems = new List<NetCafe.Models.MenuItem>
        {
            new NetCafe.Models.MenuItem { Id = 1, Name = "Hot Cappuccino", Price = 45000, ImageUrl = "img/menu-item-1.jpg", Category = "Hot" },
            new NetCafe.Models.MenuItem { Id = 2, Name = "Hot Americano", Price = 39000, ImageUrl = "img/menu-item-2.jpg", Category = "Hot" },
            new NetCafe.Models.MenuItem { Id = 3, Name = "Hot Latte", Price = 45000, ImageUrl = "img/menu-item-3.jpg", Category = "Hot" },
            new NetCafe.Models.MenuItem { Id = 4, Name = "Hot Chocolate", Price = 30000, ImageUrl = "img/menu-item-4.jpg", Category = "Hot" },
            new NetCafe.Models.MenuItem { Id = 5, Name = "Iced Cappuccino", Price = 40000, ImageUrl = "img/menu-item-5.jpg", Category = "Cold" },
            new NetCafe.Models.MenuItem { Id = 6, Name = "Iced Americano", Price = 45000, ImageUrl = "img/menu-item-6.jpg", Category = "Cold" },
            new NetCafe.Models.MenuItem { Id = 7, Name = "Iced Milky Latte", Price = 45000, ImageUrl = "img/menu-item-7.jpg", Category = "Cold" },
            new NetCafe.Models.MenuItem { Id = 8, Name = "Iced Mocha", Price = 30000, ImageUrl = "img/menu-item-8.jpg", Category = "Cold" }
        };
    }

    public ActionResult Index()
    {
        return View();
    }

    public ActionResult Menu()
    {
        return View(_menuItems);
    }

    public ActionResult About()
    {
        return View();
    }

    public ActionResult Contact()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Contact(ContactMessage message)
    {
        if (ModelState.IsValid)
        {
            // In a real application, save the message to a database
            // For now, we'll just redirect to a thank you page
            return RedirectToAction("ThankYou");
        }
        return View(message);
    }

    public ActionResult ThankYou()
    {
        return View();
    }
}

// Controllers/CartController.cs
public class CartController : Controller
{
    private List<CartItem> _cart;

    public CartController()
    {
        // Initialize cart (in a real app, this would be stored in session or database)
        _cart = new List<CartItem>();
    }

    public ActionResult Index()
    {
        return View(_cart);
    }

    [HttpPost]
    public ActionResult AddToCart(int menuItemId)
    {
        // Logic to add item to cart
        // For now, just return a JSON result
        return Json(new { success = true });
    }

    [HttpPost]
    public ActionResult RemoveFromCart(int cartItemId)
    {
        // Logic to remove item from cart
        // For now, just return a JSON result
        return Json(new { success = true });
    }

    [HttpPost]
    public ActionResult UpdateQuantity(int cartItemId, int quantity)
    {
        // Logic to update item quantity
        // For now, just return a JSON result
        return Json(new { success = true });
    }



}


public class OrderController : Controller
    {
        // Action để hiển thị trang hóa đơn
        public ActionResult Summary()
        {
            // Tạo danh sách mẫu các mặt hàng (trong thực tế, dữ liệu này sẽ đến từ database hoặc session)
            var orderItems = new List<OdrItem>
            {
                new OdrItem { Id = 1, Name = "Hot Cappuccino", Price = 45000,Quantity = 1, ImagePath = "img/menu-item-1.jpg" },
                new OdrItem { Id = 2, Name = "Iced Americano", Price = 45000, Quantity = 1, ImagePath = "img/menu-item-2.jpg" }
            };

            // Truyền danh sách mặt hàng đến view
            return View(orderItems);
        }

        // Action để xử lý thanh toán (chỉ là placeholder)
        [HttpPost]
        public ActionResult ProcessPayment()
        {
            // Xử lý logic thanh toán ở đây
            return Json(new { success = true, message = "Thanh toán đang được xử lý" });
        }
    }
