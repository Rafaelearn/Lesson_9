namespace Lab_9
{
    interface ICipher
    {
        void Encode(ref string s);
        void Decode(ref string s);
    }
}
