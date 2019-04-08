﻿namespace ServerlessLibraryAPI.OAuth.GitHub
{
    /// <summary>
    /// Default values used by the GitHub authentication middleware.
    /// </summary>
    public static class GitHubAuthenticationDefaults
    {
        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.Name"/>.
        /// </summary>
        public const string AuthenticationScheme = "GitHub";

        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.DisplayName"/>.
        /// </summary>
        public const string DisplayName = "GitHub";

        /// <summary>
        /// Default value for <see cref="AuthenticationSchemeOptions.ClaimsIssuer"/>.
        /// </summary>
        public const string Issuer = "GitHub";

        /// <summary>
        /// Default value for <see cref="RemoteAuthenticationOptions.CallbackPath"/>.
        /// </summary>
        public const string CallbackPath = "/signin-github";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.AuthorizationEndpoint"/>.
        /// </summary>
        public const string AuthorizationEndpoint = "https://github.com/login/oauth/authorize";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.TokenEndpoint"/>.
        /// </summary>
        public const string TokenEndpoint = "https://github.com/login/oauth/access_token";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.UserInformationEndpoint"/>.
        /// </summary>
        public const string UserInformationEndpoint = "https://api.github.com/user";

        /// <summary>
        /// Default value for <see cref="GitHubAuthenticationOptions.UserEmailsEndpoint"/>.
        /// </summary>
        public const string UserEmailsEndpoint = "https://api.github.com/user/emails";

        /// <summary>
        /// Scope for <see cref="UserInformationEndpoint"/>.
        /// </summary>
        public const string UserInformationScope = "user";

        /// <summary>
        /// Scope for <see cref="UserEmailsEndpoint"/>.
        /// </summary>
        public const string UserEmailsScope = "user:email";
    }
}
