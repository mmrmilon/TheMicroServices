﻿namespace Purchase.DTO
{
    using System;
    using System.Collections.Generic;

    public class PurchaseDTO
    {
        public DateTime PurchaseDate { get; set; }

        public int TotalPrice { get; set; }

        public IEnumerable<PurchaseItemDTO> PurchaseItems { get; set; }

    }
}
