namespace SoapUI.Rcc.Classes
{
    class JSONArgument
    {
        public string type;
        public dynamic value;

        public JSONArgument(string type, dynamic value)
        {
            this.type = type;
            this.value = value;
        }
    }
}
