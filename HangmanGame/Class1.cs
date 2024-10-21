using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Class1
    {
     private string  _state;
     private char _letter;
     private string _displayState;


        private string[] turkish_states = {
     "ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AKSARAY", "AMASYA", "ANKARA",
    "ANTALYA", "ARDAHAN", "ARTVİN", "AYDIN", "BALIKESİR", "BARTIN", "BATMAN",
    "BAYBURT", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE",
    "ÇANKIRI", "ÇORUM", "DENİZLİ", "DİYARBAKIR", "DÜZCE", "EDİRNE", "ELAZIĞ", "ERZİNCAN",
    "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY",
    "IĞDIR", "ISPARTA", "İSTANBUL", "İZMİR", "KAHRAMANMARAŞ", "KARABÜK", "KARAMAN",
    "KARS", "KASTAMONU", "KAYSERİ", "KİLİS", "KIRIKKALE", "KIRKLARELİ", "KIRŞEHİR",
    "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "MARDİN", "MERSİN", "MUĞLA",
    "MUŞ", "NEVŞEHİR", "NİĞDE", "ORDU", "OSMANİYE", "RİZE", "SAKARYA", "SAMSUN",
    "SİİRT", "SİNOP", "SİVAS", "ŞANLIURFA", "ŞIRNAK", "TEKİRDAĞ", "TOKAT", "TRABZON",
    "TUNCELİ", "UŞAK", "VAN", "YALOVA", "YOZGAT", "ZONGULDAK" };


        public void SetState (string state)
       { _state = state; }

       public void SetLetter (char latter) 
       { _letter = latter; }

        public string GetState ()
        { return _state; }

        public char GetLetter ()
        { return _letter; }

        public void SetdisplayState(String s)
        {
            _displayState = s;
        }

        public string GetdisplayState()
        { return _displayState; }

        public void GetRandomState()
        {
            Random rand = new Random();
            _state=turkish_states[rand.Next(1,81)];
        }

        public int GetRandomLatter()
        {
            Random rand = new Random();
            int randLetter = rand.Next(1, _state.Length-1);
            return randLetter;
        }

        public string GetUnderscore()
        {
            string str = "";
            for(int i = 0; i < _state.Length; i++)
            {
              str+= "_";
            }

            return str;
        }

        public void SaveDisplayState(int i)
        {
           _displayState = _displayState.Remove(i, 1).Insert(i, GetLetter().ToString());
        }

        public bool LetterIsFound()
        {
            int LocalCounter = 0;
            for (int i = 0; i < _state.Length; i++)
            {
                if (_letter == _state[i])
                {
                    SaveDisplayState(i);
                    LocalCounter++;
                }
            }

            return (LocalCounter != 0);

        }
             


    }
}
