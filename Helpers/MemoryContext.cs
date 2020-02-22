using System;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Http;
using GEM.Repository;
using System.Collections.Generic;

namespace GEM.Helpers{
    public static class MemoryContext
    {
        public static IMemoryCache Cache;
        public static ISession Session;

        public static string GetKeyName<T>(int Cod_Comum = 0){
            string name = typeof(T).FullName;
            name = name.Replace("System.Collections.Generic.List`1[", "").Replace(", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]", "");
            return Cod_Comum == 0 ? name : name + "." + Cod_Comum.ToString();   
        }
        
        /*public static T GetSession<T>(int Cod_Comum = 0){
            string Key = GetKeyName<T>(Cod_Comum);
            if (Session.GetString(Key) == null)
                {
                    string json = JSON.Serialize(Activator.CreateInstance<T>());
                    Session.SetString(Key, json);
                }
                return JSON.Deserialize<T>(Session.GetString(Key));
        } 

        public static void SetSession<T>(object value, int Cod_Comum = 0){
            string Key = GetKeyName<T>(Cod_Comum);
            Session.SetString(Key, JSON.Serialize(value));
        }

        public static void CleanSession<T>(int Cod_Comum = 0){
            SetSession<T>(Activator.CreateInstance<T>(), Cod_Comum);
        }*/

        public static T GetCache<T>(int Cod_Comum = 0){
            string Key = GetKeyName<T>(Cod_Comum);
            if (Cache.Get(Key) == null)
            {
                Cache.Set(Key, Activator.CreateInstance<T>());
            }
            return (T)Cache.Get(Key);
        } 

        public static void SetCache<T>(object value, int Cod_Comum = 0){
            string Key = GetKeyName<T>(Cod_Comum);
            Cache.Set(Key, value == null ? null : value);
        }

        public static void CleanCache<T>(int Cod_Comum = 0){
            SetCache<T>(Activator.CreateInstance<T>(), Cod_Comum);
        }
    }
}