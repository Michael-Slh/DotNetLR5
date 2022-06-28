using Lab05.Abstract;

namespace Lab05.States
{
    public class ProccessingState : State
    {
        public override State GetNextState()
        {
            if (IsCorrect())
            {
                return new ApprovedState();
            }
            return new RejectedState("You have non-correct symbols in your name or surname.");
        }

        public override string GetStatus()
        {
            return "Proccessing.";
        }
        public override bool IsCorrect()
        {
            return !_order.Name.Any(char.IsDigit) && !_order.Surname.Any(char.IsDigit);
        }
    }
}
