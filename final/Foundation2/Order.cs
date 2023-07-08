public class Order
{
    private Customer _customer;
    private List<Product> _productList = new List<Product>();

    public void SetOrderCustomer(Customer customer)
    {
        _customer = customer;
    }
    public void AddOrderProduct(string name, string id, float price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _productList.Add(product);
    }
    public float CalculateCost()
    {
        int shippingCost;
        if (_customer.LocationInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        float totalCost = 0;
        foreach (Product product in _productList)
        {
            totalCost += product.ProductPrice();
        }
        return (totalCost + shippingCost);
    }
    public List<string> PackingLavel()
    {
        List<string> products = new List<string>();
        foreach (Product product in _productList)
        {
            products.Add($" > Product name: {product.GetProductName()} - ID: {product.GetProductId()}");
        }
        return products;
    }
    public string ShippingLavel()
    {
        return $" > Customer name: {_customer.GetCustomerName()}\n > Address: {_customer.GetCustomerLocation()}";
    }
}