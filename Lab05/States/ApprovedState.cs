using Lab05.Abstract;

namespace Lab05.States
{
    public class ApprovedState : State
    {
        public ApprovedState()
        {
            IsClosed = true;
        }
        public override State? GetNextState()
        {
            return null;
        }

        public override string GetStatus()
        {
            return "Approved.";
        }
    }
}
