using System;
using System.Collections.Generic;
using System.Reflection;

namespace GameServer.Rcc.Classes
{
    class LuaValue
    {
        public dynamic value;
        public dynamic type;
        public dynamic table;

        public object this[string objectName]
        {
            get
            {
                if (objectName == "value")
                    return value;
                else if (objectName == "type")
                    return table;
                else if (objectName == "table")
                    return table;
                else
                    return null;
            }
            set
            {
                if (objectName == "value")
                    this.value = value;
                else if (objectName == "type")
                    type = value;
                else if (objectName == "table")
                    table = value;
            }
        }

        static dynamic serializeValue(dynamic value)
        {
            LuaValue luaValue = new LuaValue(null);
            luaValue.type = LuaType.CastToLuaType(value);

            Type valueType = value.GetType();

            if(valueType.IsArray)
            {
                List<LuaValue> list = new List<LuaValue>();
                foreach(dynamic val in value)
                {
                    list.Add(new LuaValue(val));
                }
            } else
            {
                luaValue.value = value;
            }

            return luaValue;
        }

        static dynamic deserializeValue(dynamic value)
        {
            Type valueType = value.GetType();

            if(valueType.IsArray)
            {
                var list = new List<dynamic>();

                foreach (dynamic val in value)
                {
                    list.Add(deserializeValue(val));
                }
            } else
            {
                if (value.type == LuaType.LUA_TTABLE && (value.table.LuaValue != null))
                {
                    var list = new List<dynamic>();

                    if(value.table.LuaValue.GetType().IsArray)
                    {
                        value = value.table.LuaValue;
                    } else
                    {
                        value = value.table;
                    }

                    foreach(dynamic val in value)
                    {
                        list.Add(val.deserialize());
                    }
                } else if(value.type == LuaType.LUA_TNIL)
                {
                    value = null;
                } else
                {
                    value = value.value;
                }
            }
            return value;
        }

        public dynamic deserialize()
        {
            return LuaValue.deserializeValue(this);
        }

        public LuaValue(dynamic value)
        {
            if(!value.Equals(null))
            {
                LuaValue luaValue = serializeValue(value);

                PropertyInfo[] propertyInfo = luaValue.GetType().GetProperties();

                foreach (PropertyInfo pi in propertyInfo)
                {
                    this[pi.Name] = pi.GetValue(luaValue, null);
                }
            }
        }
    }
}
