using Lab05.Abstract;

namespace Lab05.States
{
    public class RejectedState : State
    {
        public string RejectionReason { get; }
        public RejectedState(string rejectionReason)
        {
            IsClosed = true;
            RejectionReason = rejectionReason;
        }
        public override string GetStatus()
        {
            return "Rejected. For reason " + RejectionReason;
        }

        public override State? GetNextState()
        {
            return null;
        }
    }
}
