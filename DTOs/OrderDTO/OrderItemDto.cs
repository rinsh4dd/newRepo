﻿public class OrderItemDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string Size { get; set; }
    public byte[] ImageData { get; set; }
    public string ImageMimeType { get; set; }
}