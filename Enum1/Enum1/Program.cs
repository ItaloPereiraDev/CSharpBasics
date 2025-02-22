using Enum1.Entities;
using Enum1.Entities.Enums;

Order order = new Order
{
    Id = 1,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment,
};
Console.WriteLine(order);

//Aqui eu tenho um valor do tipo enumerado, e quero converter pra string
string txt = order.Status.ToString();
Console.WriteLine(txt);

//Aqui é o contrário, eu tenho o valor em string, o txt, e quero converter pra tipo enumerado
OrderStatus num = Enum.Parse<OrderStatus>(txt);
Console.WriteLine(num);