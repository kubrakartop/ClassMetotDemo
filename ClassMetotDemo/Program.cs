using ClassMetotDemo;

static void Add(Customer customer)
{
    Console.WriteLine(customer.ID + " " + customer.CustomerName + " " + customer.CustomerLastname + " " + customer.PhoneNumber + "" + customer.Email + " " + "Customer Information Added");
}

static void Delete(Customer customer)
{
    Console.WriteLine(customer.ID + " " + customer.CustomerName + " " + customer.CustomerLastname + " " + customer.PhoneNumber + "" + customer.Email + " " + "Customer Information Deleted");
}

static void ListCostumer(Customer customer)
{
    Console.WriteLine(customer.ID + " " + customer.CustomerName + " " + customer.CustomerLastname + " " + customer.PhoneNumber + "" + customer.Email + "" + "Customer Information");

}
Customer customer1=new Customer();
customer1.ID = 1;
customer1.CustomerName = "Sophia";
customer1.CustomerLastname = "Brown";
customer1.PhoneNumber = +1402221112;
customer1.Email = "sophiab@gmail.com";

Customer customer2 = new Customer();
customer2.ID = 2;
customer2.CustomerName = "Laya";
customer2.CustomerLastname = "Hayes";
customer2.PhoneNumber = +140281113;
customer2.Email = "hayesl@gmail.com";

Customer customer3 = new Customer();
customer3.ID = 3;
customer3.CustomerName = "David";
customer3.CustomerLastname = "Stone ";
customer3.PhoneNumber = +140268116;
customer3.Email = "stone@gmail.com";

Customer customerManeger=new Customer();
customerManeger.Add(customer1);
customerManeger.Delete(customer2);
customerManeger.ListCustomer(customer3);

Customer customerManager1 = new Customer();
Customer[] customers = new Customer[] { customer1, customer2, customer3 };

foreach (var customer in customers)
{
    Console.WriteLine(customer.ID + " " + customer.CustomerName + " " + customer.CustomerLastname + " " + customer.PhoneNumber + " "+ customer.Email );

}
