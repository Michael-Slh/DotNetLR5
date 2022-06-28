using Lab05.Logic;

namespace Lab05.Abstract
{
    public abstract class State
    {
        public bool IsClosed { get; protected set; } = false;
        protected Order _order;
        public void SetOrder(Order order)
        {
            _order = order;
        }
        public virtual bool IsCorrect()
        {
            return !string.IsNullOrEmpty(_order.Name) && !string.IsNullOrEmpty(_order.Surname);
        }
        public abstract string GetStatus();
        public abstract State? GetNextState();
    }
}
