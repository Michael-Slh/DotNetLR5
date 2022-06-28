using Lab05.Logic;

namespace Lab05
{
    public class OrdersRegistry
    {
        private readonly List<Order> _orders = new();
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public void ConsiderAll()
        {
            foreach (var order in _orders)
            {
                if (!order.IsClosed)
                {
                    var nextState = order.GetNextState();

                    if (nextState != null)
                    {
                        order.ChangeState(nextState);
                        order.LastConsidered = DateTime.Now;
                    }
                }
            }
        }
        public void ClearFinishedOrders()
        {
            var ordersToRemove = _orders.Where(o => o.IsClosed).ToList();
            foreach (var order in ordersToRemove)
            {
                _orders.Remove(order);
            }
        }
        public List<Order> GetAllOrders()
        {
            return _orders;
        }
    }
}
