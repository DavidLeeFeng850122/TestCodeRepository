namespace MatchesPlay
{
    public class MediatorPater : AbstractMediator
    {
        public MediatorPater(AbstractPlayer a, AbstractPlayer b)
            : base(a, b)
        {

        }

        public override void AWin(int count)
        {
            if (count == 1)
            {
                _playerA.PickUpCount += count;
            }
        }

        public override void BWin(int count)
        {
            if (count == 1)
            {
                _playerB.PickUpCount += count;
            }
        }
    }
}
