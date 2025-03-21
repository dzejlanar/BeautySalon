﻿namespace BeautySalon.Model.ViewModels
{
    public class ServiceVM
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public long Duration { get; set; }
        public string? Status { get; set; }
        public ServiceCategoryVM? Category { get; set; }
    }
}
