using Lab05.Abstract;

namespace Lab05.States
{
    public class CreatedState : State
    {
        public override State? GetNextState()
        {
            if (IsCorrect())
                return new ProccessingState();
            return new RejectedState("Name or surname are empty fields.");
        }

        public override string GetStatus()
        {
            return "Created.";
        }
    }
}
