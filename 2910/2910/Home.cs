using System;
using System.Collections.Generic;
using System.Text;

namespace _2910
{
    class Home
    {  
        int otaqSayi;
        public int mertebeSayi {
            get { return mertebeSayi; }
            set { this.mertebeSayi = mertebeSayi; }
        }
        string unvan;
        string telefon;
        public string seher;

        public Home(string seher) {
            this.seher = seher;
        }
        public Home(int otaqSayi, int mertebeSayi, string unvan, string telefon, string seher)
        {
            this.otaqSayi = otaqSayi;
            this.mertebeSayi = mertebeSayi;
            this.unvan = unvan;
            this.telefon = telefon;
            this.seher = seher;
        }

        public int MyProperty { get; set; }

        public string toString()
        {
            return $"Unvan - {unvan}, telephone - {telefon}, sheher - {seher}";
        }
    }
}
