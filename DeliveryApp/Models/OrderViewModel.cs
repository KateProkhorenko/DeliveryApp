﻿namespace DeliveryApp.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; } = new Order();
        public string Action { get; set; } = "Create";
        public bool ReadOnly { get; set; } = false;
        public string Theme { get; set; } = "primary";
        public bool ShowAction { get; set; } = true;
    }
}
