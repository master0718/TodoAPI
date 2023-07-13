﻿namespace TodoApi;

public static class AuthenticationExtensions
{
    public static WebApplicationBuilder AddAuthentication(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthentication().AddBearerToken(AuthenticationHelper.BearerTokenScheme);

        return builder;
    }
}
