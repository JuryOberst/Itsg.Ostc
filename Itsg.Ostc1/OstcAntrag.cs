﻿using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Itsg.Ostc1
{
    partial class OstcAntrag
    {
        /// <remarks/>
        [XmlAttribute(Namespace = "http://www.w3.org/2001/XMLSchema-instance", Form = XmlSchemaForm.Qualified, AttributeName = "noNamespaceSchemaLocation")]
        public string NoNamespaceSchemaLocation
        {
            get { return "OSTC.xsd"; }
            set { }
        }
    }
}
