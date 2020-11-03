﻿namespace Sales.DTO
{
    using System;
    using System.Collections.Generic;

    public class SalesDTO
    {
        public string SalesId { get; set; }

        public DateTime SalesDate { get; set; }

        public IList<SalesProductDTO> SalesProducts { get; set; }

        public SalesDTO()
        {
            this.SalesProducts = new List<SalesProductDTO>();
        }
    }

    public class SalesProductDTO
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public string UnitName { get; set; }

        public long SalesUnitPrice { get; set; }

        public long SalesQuantity { get; set; }
    }
}
