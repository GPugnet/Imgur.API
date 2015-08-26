﻿using Imgur.API.Models;

namespace Imgur.API.Authentication.Impl
{
    /// <summary>
    ///     Imgur API application credentials.
    ///     Register at https://api.imgur.com/oauth2/addclient
    /// </summary>
    public class ImgurAuthentication : ApiAuthenticationBase, IImgurAuthentication
    {
        /// <summary>
        ///     Initializes a new instance of the ImgurAuthentication class.
        /// </summary>
        /// <param name="clientId">The Imgur app's ClientId. </param>
        /// <param name="clientSecret">The Imgur app's ClientSecret.</param>
        public ImgurAuthentication(string clientId, string clientSecret) : base(clientId, clientSecret)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the ImgurAuthentication class.
        /// </summary>
        /// <param name="clientId">The Imgur app's ClientId. </param>
        /// <param name="clientSecret">The Imgur app's ClientSecret.</param>
        /// <param name="oAuth2Token">An OAuth2 Token used for actions against a user's account.</param>
        public ImgurAuthentication(string clientId, string clientSecret, IOAuth2Token oAuth2Token)
            : base(clientId, clientSecret, oAuth2Token)
        {
        }
    }
}