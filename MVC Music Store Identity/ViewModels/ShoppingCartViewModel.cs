using MVC_Music_Store_Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Music_Store_Identity.ViewModels
{
    public class ShoppingCartViewModel
    {

        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}