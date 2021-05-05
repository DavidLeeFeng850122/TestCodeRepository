namespace MatchesPlay
{
    public abstract class AbstractMediator
    {
        protected AbstractPlayer _playerA;
        protected AbstractPlayer _playerB;

        public AbstractMediator(AbstractPlayer playerA, AbstractPlayer playerB)
        {
            _playerA = playerA;
            _playerB = playerB;
        }

        public abstract void AWin(int count);
        public abstract void BWin(int count);
    }
}
