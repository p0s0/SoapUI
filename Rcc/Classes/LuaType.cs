using System;
using System.Linq;

namespace GameServer.Rcc
{
    public class LuaType
    {
        public const string LUA_TNIL = "LUA_TNIL";
        public const string LUA_TBOOLEAN = "LUA_TBOOLEAN";
        public const string LUA_TNUMBER = "LUA_TNUMBER";
        public const string LUA_TSTRING = "LUA_TSTRING";
        public const string LUA_TTABLE = "LUA_TTABLE";

        public static string GetFriendlyName(Type type)
        {
            if (type == typeof(int))
                return "int";
            else if (type == typeof(short))
                return "short";
            else if (type == typeof(byte))
                return "byte";
            else if (type == typeof(bool))
                return "bool";
            else if (type == typeof(long))
                return "long";
            else if (type == typeof(float))
                return "float";
            else if (type == typeof(double))
                return "double";
            else if (type == typeof(decimal))
                return "decimal";
            else if (type == typeof(string))
                return "string";
            else if (type == typeof(Array))
                return "array";
            else if (type.Equals(null))
                return "NULL";
            else if (type.IsGenericType)
                return type.Name.Split('`')[0] + "<" + string.Join(", ", type.GetGenericArguments().Select(x => GetFriendlyName(x)).ToArray()) + ">";
            else if (type == typeof(object))
                return "object";
            else
                return type.Name;
        }

        public static string CastToLuaType(dynamic value)
        {
            string friendlyName = GetFriendlyName(value.GetType());

            if (friendlyName == "NULL")
                return LUA_TNIL;
            else if (friendlyName == "bool")
                return LUA_TBOOLEAN;
            else if (friendlyName == "int")
                return LUA_TNUMBER;
            else if (friendlyName == "double")
                return LUA_TNUMBER;
            else if (friendlyName == "string")
                return LUA_TSTRING;
            else if (friendlyName == "array")
                return LUA_TTABLE;
            else if (friendlyName == "object")
                return LUA_TNIL;
            else
                return LUA_TNIL;
        }
    }
}