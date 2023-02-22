﻿namespace RestaurantService.Api {
    public class TogoOrder {
        public int Id { get; set; }
        public DateTime? OrderCreated { get; set; }
        public List<MenuItem>? ItemsOrdered { get; set; }
        public Decimal? Subtotal { get; set; }
        public Decimal? Tax { get; set; }
        public Decimal? Total { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}