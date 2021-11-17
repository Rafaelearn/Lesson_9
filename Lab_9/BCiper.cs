namespace Lab_9
{
    class BCiper : ICipher
    {
        private string abc = "abcdefghijklmnopqrstuvwxyz";
        private string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public void Decode(ref string s)
        {
            Encode(ref s);
        }
        public void Encode(ref string s)
        {
            string strNew = "";
            for (int i = 0; i < s.Length; i++)
            {
                int index = abc.IndexOf(s[i]);
                if (index == -1)
                {
                    index = ABC.IndexOf(s[i]);
                    if (index != -1)
                    {
                        strNew += ABC[ABC.Length - 1 - index];
                    }
                    else
                    {
                        strNew += s[i];
                    }
                }
                else
                {
                    strNew += abc[abc.Length - 1 - index];
                }
            }
            s = strNew;
        }
    }
}
