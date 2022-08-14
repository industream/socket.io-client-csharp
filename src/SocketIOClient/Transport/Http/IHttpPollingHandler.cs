﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SocketIOClient.Transport.Http
{
    public interface IHttpPollingHandler
    {
        Action<string> OnTextReceived { get; set; }
        Action<byte[]> OnBytesReceived { get; set; }
        Task GetAsync(string uri, CancellationToken cancellationToken);
        Task SendAsync(HttpRequestMessage req, CancellationToken cancellationToken);
        Task PostAsync(string uri, string content, CancellationToken cancellationToken);
        Task PostAsync(string uri, IEnumerable<byte[]> bytes, CancellationToken cancellationToken);
    }
}
