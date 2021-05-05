namespace MatchesPlay
{
    public abstract class AbstractPlayer
    {
        public int PickUpCount { get; set; }

        public AbstractPlayer()
        {
            PickUpCount = 0;
        }

        public abstract bool ChangeCount(int count, AbstractMediator mediator, MatchesRow matchesRow);
    }
}
