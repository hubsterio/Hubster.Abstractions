using Hubster.Abstractions.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubster.Abstractions.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class ModelExtensions
    {
        /// <summary>
        /// Determines whether the specified conversation is paused.
        /// </summary>
        /// <param name="conversation">The conversation.</param>
        /// <returns>
        ///   <c>true</c> if the specified conversation is paused; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPaused(this ConversationModel conversation)
        {
            return conversation.Integration.StatusId == ApplicationType.IntegrationStatus.Paused
                || conversation.Integration.Hub.StatusId == ApplicationType.HubStatus.Paused;
        }

        /// <summary>
        /// Determines whether the specified integration is paused.
        /// </summary>
        /// <param name="integration">The integration.</param>
        /// <returns>
        ///   <c>true</c> if the specified integration is paused; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPaused(this IntegrationModel integration)
        {
            return integration.StatusId == ApplicationType.IntegrationStatus.Paused
                || integration.Hub.StatusId == ApplicationType.HubStatus.Paused;
        }

        /// <summary>
        /// Determines whether the specified hub is paused.
        /// </summary>
        /// <param name="hub">The hub.</param>
        /// <returns>
        ///   <c>true</c> if the specified hub is paused; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPaused(this HubModel hub)
        {
            return hub.StatusId == ApplicationType.HubStatus.Paused;
        }

        /// <summary>
        /// Determines whether the specified conversation is disabled.
        /// </summary>
        /// <param name="conversation">The conversation.</param>
        /// <returns>
        ///   <c>true</c> if the specified conversation is disabled; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDisabled(this ConversationModel conversation)
        {
            return conversation.Integration.Hub.Tenant.StatusId == ApplicationType.TenantStatus.Disabled;
        }

        /// <summary>
        /// Determines whether the specified integration is disabled.
        /// </summary>
        /// <param name="integration">The integration.</param>
        /// <returns>
        ///   <c>true</c> if the specified integration is disabled; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDisabled(this IntegrationModel integration)
        {
            return integration.Hub.Tenant.StatusId == ApplicationType.TenantStatus.Disabled;
        }

        /// <summary>
        /// Determines whether the specified hub is disabled.
        /// </summary>
        /// <param name="hub">The hub.</param>
        /// <returns>
        ///   <c>true</c> if the specified hub is disabled; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDisabled(this HubModel hub)
        {
            return hub.Tenant.StatusId == ApplicationType.TenantStatus.Disabled;
        }

        /// <summary>
        /// Determines whether the specified tenant is disabled.
        /// </summary>
        /// <param name="tenant">The tenant.</param>
        /// <returns>
        ///   <c>true</c> if the specified tenant is disabled; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDisabled(this TenantModel tenant)
        {
            return tenant.StatusId == ApplicationType.TenantStatus.Disabled;
        }
    }
}
