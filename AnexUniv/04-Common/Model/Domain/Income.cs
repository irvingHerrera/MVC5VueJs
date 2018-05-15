﻿using Common;

namespace Model.Domain
{
    public class Income
    {
        public int Id { get; set; }
        public Enums.EntityType EntityType { get; set; }
        public Enums.IncomeType IncomeType { get; set; }
        public decimal Total { get; set; }
        public int EntityId { get; set; }
    }
}
