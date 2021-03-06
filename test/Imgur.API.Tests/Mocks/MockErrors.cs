﻿namespace Imgur.API.Tests.Mocks
{
    public class MockErrors
    {
        public const string ImgurCapacityError =
            "{\"data\":{\"error\":\"Imgur is over capacity. Please try again.\", \"request\":\"/image/MwJTXbW\", \"method\":\"POST\" }, \"success\":false, \"status\":1203 }";

        public const string ImgurClientError =
            "{\"data\":{\"error\":\"Authentication required\",\"request\":\"/credits\",\"method\":\"POST\"},\"success\":false,\"status\":401}";

        public const string MashapeError =
            "{\"message\":\"Missing Mashape application key.Go to http://docs.mashape.com/api-keys to learn how to get your API application key.\"}";
    }
}