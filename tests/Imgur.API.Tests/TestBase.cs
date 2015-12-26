﻿using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using Imgur.API.Models.Impl;
using Imgur.API.Tests.FakeResponses;
using NSubstitute;

namespace Imgur.API.Tests
{
    public abstract class TestBase
    {
        public IOAuth2Token FakeOAuth2Token
            =>
                Substitute.For<EndpointBase>()
                    .ProcessEndpointResponse<OAuth2Token>(OAuth2EndpointResponses.OAuth2TokenCodeResponse);
    }
}