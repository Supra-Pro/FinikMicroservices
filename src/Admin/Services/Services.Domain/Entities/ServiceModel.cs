﻿namespace Services.Domain.Entities
{
    public class ServiceModel
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
