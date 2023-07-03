namespace SoapUI.Rcc.Classes
{
    class LuaValueNew
    {
        public string type;
        public dynamic value;
        public LuaValueNew(string type = "LUA_TNIL", dynamic value = null)
        {
            this.type = type;
            this.value = value;
        }
    }
}
