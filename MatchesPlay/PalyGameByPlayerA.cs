namespace MatchesPlay
{
    public class PalyGameByPlayerA : AbstractPlayer
    {
        public override bool ChangeCount(int count, AbstractMediator mediator, MatchesRow matchesRow)
        {
            if (matchesRow.RowNumber > 0 && count == 1)
            {
                mediator.AWin(count);
                matchesRow.RowNumber -= count;
            }

            if (matchesRow.RowNumber == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
