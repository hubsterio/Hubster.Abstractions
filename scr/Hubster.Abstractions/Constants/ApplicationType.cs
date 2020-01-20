// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

namespace Hubster.Abstractions.Constants
{
    public class ApplicationType
    {
        public class Group
        {
            public const int Tenant = 1;
            public const int UserCompanyRole = 2;
            public const int TenantStatus = 100;
            public const int HubStatus = 200;
            public const int IntegrationStatus = 300;

            public static bool IsValid(int? id) { return id >= Tenant && id <= IntegrationStatus; }
        }

        public class Tenant
        {
            public const int B2BCompany = 100;
            public const int B2CCompan = 101;
            public const int DigitalAgency = 102;
            public const int BotDeveloper = 103;
            public const int CallCenter = 104;
            public const int Other = 105;

            public static bool IsValid(int? id) { return id >= B2BCompany && id <= Other; }
        }

        public class UserCompanyRole
        {
            public const int Architect = 200;
            public const int C_Level = 201;
            public const int CustomerSuccess = 202;
            public const int Developer = 203;
            public const int Director = 204;
            public const int Marketing = 205;
            public const int Operations = 206;
            public const int Other = 207;
            public const int Sales = 208;

            public static bool IsValid(int? id) { return id >= Architect && id <= Sales; }
        }

        public class TenantStatus
        {
            public const int Active = 1000;
            public const int Canceled = 1001;
            public const int Disabled = 1002;

            public static bool IsValid(int? id) { return id >= Active && id <= Disabled; }
        }

        public class HubStatus
        {
            public const int Active = 2000;
            public const int Canceled = 2001;
            public const int Paused = 2002;

            public static bool IsValid(int? id) { return id >= Active && id <= Paused; }            
        }

        public class IntegrationStatus
        {
            public const int Active = 3000;
            public const int Canceled = 3001;
            public const int Paused = 3002;

            public static bool IsValid(int? id) { return id >= Active && id <= Paused; }
        }
    }
}
