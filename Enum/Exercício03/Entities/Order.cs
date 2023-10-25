using System.Text;
using Exercício03.Entities.Enums;

namespace Exercício03.Entities
{
    public class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order () {}
        public Order (DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddOrder(OrderItem orders) {
            OrderItems.Add(orders);
        }

        public void RemoveOrder(OrderItem orders) {
            OrderItems.Remove(orders);
        }

        public double Total() {
            double sum = 0.0;
            foreach (OrderItem item in OrderItems) {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in OrderItems) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: ${Total():F2}");

            return sb.ToString();
        }
    }
}