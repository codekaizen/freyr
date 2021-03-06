﻿using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class FoodsListRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodsListRequest FoodsListRequest;

        public FoodsListRequest1()
        {
        }

        public FoodsListRequest1(FoodsListRequest foodsListRequest) => FoodsListRequest = foodsListRequest;
    }
}