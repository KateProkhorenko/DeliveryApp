namespace DeliveryApp.Models
{
    public static class ViewModelFactory
    {
        public static OrderViewModel Details(Order r)
        {
            return new OrderViewModel
            {
                Order = r,
                Action = "Details",
                ReadOnly = true,
                Theme = "info",
                ShowAction = false
            };
        }
        public static OrderViewModel Create(Order order) 
        {
            return new OrderViewModel
            {
                Order = order
            };
        }
    }
}
