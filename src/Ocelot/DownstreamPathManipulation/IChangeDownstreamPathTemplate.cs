﻿using System.Collections.Generic;
using System.Security.Claims;

using Ocelot.Configuration;
using Ocelot.DownstreamRouteFinder.UrlMatcher;
using Ocelot.Responses;
using Ocelot.Values;

namespace Ocelot.PathManipulation
{
    public interface IChangeDownstreamPathTemplate
    {
        Response ChangeDownstreamPath(List<ClaimToThing> claimsToThings, IEnumerable<Claim> claims,
            DownstreamPathTemplate downstreamPathTemplate, List<PlaceholderNameAndValue> placeholders);
    }
}
