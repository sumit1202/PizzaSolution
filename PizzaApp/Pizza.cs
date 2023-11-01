//Pizza model
using System;

namespace PizzaApp
{
    internal class Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string? Type { get; set; }
    }
}