﻿using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public enum GroupType
    {
        /// <remarks />
        Allergen,

        /// <remarks />
        Food,

        /// <remarks />
        Nutrient,

        /// <remarks />
        Consumer,

        /// <remarks />
        Haccp,

        /// <remarks />
        Archive
    }
}