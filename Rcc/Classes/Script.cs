using System.Collections.Generic;

namespace GameServer.Rcc.Classes
{
    class Script
    {
        public string name;
        public string script;
        public List<dynamic> arguments;

        public Script(string name = "Script", string script = "print(\"Hello, world!\")", List<dynamic> arguments = null)
        {
            this.name = name;
            this.script = script;
            this.arguments = new List<dynamic>();

            if(arguments != null)
            {
                foreach (dynamic arg in arguments)
                {
                    this.arguments.Add(new LuaValue(arg));
                }
            }
        }
    }
}
