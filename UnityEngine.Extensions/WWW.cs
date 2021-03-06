﻿using System.Xml;
using UnityEngine;

namespace UnityEngine.Extensions
{
    public static partial class UnityExtensions
    {
        public static XmlDocument AsXml(this WWW www)
        {
            if (www.error != null)
            {
                Debug.LogError(www.error);
                return null;
            }
            byte[] data = www.bytes;
            if (data == null)
                return null;

            XmlDocument doc = new XmlDocument();
            doc.Load(new System.IO.MemoryStream(data, false));
            return doc;
        }
    }
}
