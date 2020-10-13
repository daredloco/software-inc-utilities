using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SincUtilities
{
    public static class Serializer
    {
        /// <summary>
        /// Serialize an object to a byte array
        /// </summary>
        /// <param name="obj">The object you want to serialize</param>
        /// <returns>A byte array representation of the object</returns>
        public static byte[] Serialize(this object obj)
        {
            if (obj == null)
            {
                return null;
            }
            var bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Deserialize a byte array back to an object
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="byteArray">The byte array you want to deserialize</param>
        /// <returns>The object</returns>
        public static T Deserialize<T>(this byte[] byteArray) where T : class
        {
            try
            {
                if (byteArray == null)
                {
                    return null;
                }
                using (var memStream = new MemoryStream())
                {
                    var binForm = new BinaryFormatter();
                    memStream.Write(byteArray, 0, byteArray.Length);
                    memStream.Seek(0, SeekOrigin.Begin);
                    var obj = (T)binForm.Deserialize(memStream);
                    return obj;
                }
            }
            catch (SerializationException ex)
            {
                //Debug.Warn("[Helpers] SerializationException thrown while deserializing, probably harmless... => " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                //if (ex.HResult != -2147467262)
                //{
                //    //Debug.Warn("[Helpers] Unknown exception while deserializing the array! => " + ex.Message);
                //    return null;
                //}
                throw ex;
            }

        }

        [Serializable]
        /// <summary>
        /// A Dictionary that can be serialized
        /// </summary>
        public class SendableDictionary
        {
            [XmlElement]
            public List<SendableDictionaryPair> Pairs = new List<SendableDictionaryPair>();
            public SendableDictionary() { }
            public SendableDictionary(Dictionary<object, object> dict)
            {
                foreach (KeyValuePair<object, object> kvp in dict)
                    Pairs.Add(new SendableDictionaryPair(kvp.Key, kvp.Value));
            }
            public SendableDictionary(params SendableDictionaryPair[] pairs)
            {
                Pairs.AddRange(pairs);
            }

            public bool Contains(object key)
            {
                if (Pairs.Find(x => x.Key == key) != null)
                    return true;
                else
                    return false;
            }

            public object GetValue(object key)
            {
                SendableDictionaryPair p = Pairs.Find(x => x.Key == key);
                if (p == null)
                {
                    //Debug.Warn($"[XML] Couldn't find object with key {key} inside Pairs! <= Can be ignored if mod doesn't crash afterwards");
                    return null;
                }
                object value = p.Value;
                return value;
            }

            public object GetValue(string key)
            {
                SendableDictionaryPair p = Pairs.Find(x => (string)x.Key == key);
                if (p == null)
                {
                    //Debug.Warn($"[XML] Couldn't find object with key {key} inside Pairs!");
                    return null;
                }
                return p.Value;
            }

            public void Add(SendableDictionaryPair pair)
            {
                Pairs.Add(pair);
            }

            public void Add(object key, object value)
            {
                Add(new SendableDictionaryPair(key, value));
            }
        }

        [Serializable]
        /// <summary>
        /// A keyvaluepair of a XMLDictionary
        /// </summary>
        public class SendableDictionaryPair
        {
            [XmlElement]
            public object Key;
            [XmlElement]
            public object Value;
            public SendableDictionaryPair() { }
            public SendableDictionaryPair(object key, object value) { Key = key; Value = value; }
        }
    }
}
