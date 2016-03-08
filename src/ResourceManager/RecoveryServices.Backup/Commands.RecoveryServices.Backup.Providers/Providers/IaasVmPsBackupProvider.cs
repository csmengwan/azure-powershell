﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.ProviderModel
{
    public class IaasVmPsBackupProvider : IPsBackupProvider
    {
        public void Initialize(ProviderData providerData, HydraAdapter.HydraAdapter hydraAdapter)
        {
            throw new NotImplementedException();
        }

        public BaseRecoveryServicesJobResponse EnableProtection()
        {
            throw new NotImplementedException();
        }

        public BaseRecoveryServicesJobResponse DisableProtection()
        {
            throw new NotImplementedException();
        }

        public BaseRecoveryServicesJobResponse TriggerBackup()
        {
            throw new NotImplementedException();
        }

        public BaseRecoveryServicesJobResponse TriggerRestore()
        {
            throw new NotImplementedException();
        }

        public ProtectedItemResponse GetProtectedItem()
        {
            throw new NotImplementedException();
        }

        public RecoveryPointResponse GetRecoveryPoint()
        {
            throw new NotImplementedException();
        }

        public ProtectionPolicyResponse CreatePolicy()
        {
            throw new NotImplementedException();
        }

        public ProtectionPolicyResponse ModifyPolicy()
        {
            throw new NotImplementedException();
        }

        public ProtectionPolicyResponse GetPolicy()
        {
            throw new NotImplementedException();
        }

        public void DeletePolicy()
        {
            throw new NotImplementedException();
        }
    }
}
