namespace MatchesPlay
{
    public class PalyGameByPlayerB : AbstractPlayer
    {
        public override bool ChangeCount(int count, AbstractMediator mediator, MatchesRow matchesRow)
        {
            if (matchesRow.RowNumber > 0 && count == 1)
            {
                mediator.BWin(count);
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
