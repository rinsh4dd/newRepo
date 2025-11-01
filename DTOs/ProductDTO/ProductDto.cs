﻿using System.Collections.Generic;

public class ProductDTO
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public string Brand { get; set; }

    public bool isActive { get; set; }
    public bool InStock { get; set; } = true;

    public string SpecialOffer { get; set; }

    public int CategoryId { get; set; }

    public string CategoryName { get; set; }
    public int CurrentStock { get; set; }
    public List<string> AvailableSizes { get; set; } = new List<string>();
    public List<string> ImageBase64 { get; set; } = new List<string>();
}
