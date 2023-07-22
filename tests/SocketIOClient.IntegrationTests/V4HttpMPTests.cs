﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocketIO.Core;

namespace SocketIOClient.IntegrationTests
{
    [TestClass]
    public class V4HttpMPTests : HttpMpTests
    {
        protected override string ServerUrl => Common.Startup.V4_HTTP_MP;
        protected override EngineIO EIO => EngineIO.V4;
        protected override void ConfigureSerializerForEmitting1Parameter(SocketIO io)
        {
            throw new System.NotImplementedException();
        }

        protected override IEnumerable<(string EventName, object Data, string ExpectedJson, IEnumerable<byte[]>? ExpectedBytes)> Emit1ParameterTupleCases
        {
            get;
        }

        protected override string ServerTokenUrl => Common.Startup.V4_HTTP_TOKEN_MP;
    }
}