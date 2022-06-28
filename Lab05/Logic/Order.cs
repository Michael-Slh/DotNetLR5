using Lab05.Abstract;
using Lab05.States;

namespace Lab05.Logic
{
    public class Order
    {
        private static int _amount = 1;
        private readonly int _id = _amount++;
        private State _state;
        private DateTime _lastConsidered = DateTime.Now;
        public bool IsClosed
        {
            get
            {
                return _state.IsClosed;
            }
        }
        public string Name { get; init; }
        public string Surname { get; init; }
        public DateTime LastConsidered
        {
            get { return _lastConsidered; }
            set
            {
                if (value > _lastConsidered)
                {
                    _lastConsidered = value;
                }
            }
        }
        public Order()
        {
            ChangeState(new CreatedState());
        }

        public void ChangeState(State state)
        {
            _state = state;
            state.SetOrder(this);
        }

        public State? GetNextState()
        {
            return _state.GetNextState();
        }

        public override string ToString()
        {
            return $"Document number {_id}. " + "State: '" + _state.GetStatus() + "'";
        }
    }
}
