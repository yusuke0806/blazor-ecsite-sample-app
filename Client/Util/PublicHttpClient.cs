using System;

namespace BlazorECSiteSample.Client.Util;

public class PublicHttpClient
{
    public HttpClient httpClient { get; }

    public PublicHttpClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
}

