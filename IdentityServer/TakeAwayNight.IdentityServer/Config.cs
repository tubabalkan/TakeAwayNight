// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace TakeAwayNight.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
          new ApiResource("ResourceCatalog"){Scopes={ "CatalogFullPermission", "CatalogReadPermission"}},
          new ApiResource("ResourceDiscount"){Scopes={ "DiscountFullPermission"}},
          new ApiResource("ResourceDiscount2"){Scopes={ "DiscountDeletePermission"}},
          new ApiResource("ResourceOrder"){Scopes={ "OrderFullPermission"}},
          new ApiResource("ResourceCargo"){Scopes={ "CargoFullPermission"}},
          new ApiResource("ResourceBasket"){Scopes={ "BasketFullPermission"}},
          new ApiResource("ResourceComment"){Scopes={ "CommentFullPermission"}},
          new ApiResource("ResourceOcelet"){Scopes={ "OceletFullPermission"}},
          new ApiResource("ResourceMessage"){Scopes={ "MessageFullPermission"}},
          new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };
        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email()
        };
        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("CatalogFullPermission","Full access to Catalog "),
            new ApiScope("DiscountFullPermission","Full access to Discount"),
            new ApiScope("DiscountDeletePermission","Full access to Discount"),
            new ApiScope("OrderFullPermission","Full access to Order"),
            new ApiScope("CargoFullPermission","Full access to Cargo"),
            new ApiScope("BasketFullPermission","Full access to Basket"),
            new ApiScope("CommentFullPermission","Full access to Comment"),
            new ApiScope("OceletFullPermission","Full access to Ocelet"),
            new ApiScope("MessageFullPermission","Full access to Message"),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
        };
        public static IEnumerable<Client> Clients => new Client[]
        {
            new Client
            {
                ClientId="TakeAwayVisitorId",
                ClientName="TakeAwayVisitor User",
                AllowedGrantTypes=GrantTypes.ClientCredentials,
                ClientSecrets={new Secret("takeawaysecret".Sha256())},
                AllowedScopes = { "CatalogFullPermission", "OceletFullPermission", IdentityServerConstants.LocalApi.ScopeName},
                AccessTokenLifetime = 300
            },
            new Client
            {
                ClientId="TakeAwayAdminId",
                ClientName="TakeAwayAdminUser",
                AllowedGrantTypes=GrantTypes.ClientCredentials,
                ClientSecrets={new Secret("takeawaysecret".Sha256())},
                AllowedScopes = { "CatalogFullPermission", "OceletFullPermission", "DiscountFullPermission",
                    "DiscountDeletePermission","OrderFullPermission","CargoFullPermission","BasketFullPermission",
                    "CommentFullPermission","MessageFullPermission",IdentityServerConstants.LocalApi.ScopeName,
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Email,
                    IdentityServerConstants.StandardScopes.Profile},
                AccessTokenLifetime = 750
            }
        };
    }
}
