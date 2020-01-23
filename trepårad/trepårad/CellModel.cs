namespace trepårad
{
    public class CellModel
    {
        private int _content; // En variabel som skal holde på om cellen er okkupert av "X", "O" eller ingen


        // Vi inititerer _content til å være verdien 0, når vi lager et nytt object.
        public CellModel()
        {
            _content = 0;
        }

        // returnerer en bool. Hvis 0, er CellModel[i]._content = false; *Da kan man sette inn en verdi*
        public bool IsEmpty()
        {
            return _content == 0;
        }

        // True =  Betyr det at "X" Okkuperer cellen.
        public bool IsPlayer1 ()
        {
            return _content == 1;
        }

        // hvis "IsEmpty" = false return. Hvis "IsPlayer1"  true: _content = 1 false: _content = 2
        public void Mark(bool IsPlayer1)
        {
            if (!IsEmpty()) return;
            _content = IsPlayer1 ? 1 : 2;
        }
    }

}