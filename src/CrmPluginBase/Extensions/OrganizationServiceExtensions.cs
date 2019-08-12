﻿using System.Collections.Generic;
using System.Linq;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace CrmPluginBase.Extensions
{
    public static class OrganizationServiceExtensions
    {
        public static IEnumerable<Entity> Fetch(this IOrganizationService orgService, string fetchXml) =>
            orgService.RetrieveMultiple(new FetchExpression(fetchXml)).Entities;

        public static IEnumerable<TEntity> Fetch<TEntity>(this IOrganizationService orgService, string fetchXml)
            where TEntity : Entity =>
                orgService.Fetch(fetchXml).Cast<TEntity>();
    }
}
