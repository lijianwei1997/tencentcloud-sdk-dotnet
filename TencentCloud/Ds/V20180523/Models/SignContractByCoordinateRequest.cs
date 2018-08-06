/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ds.V20180523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SignContractByCoordinateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 合同ID
        /// </summary>
        [JsonProperty("ContractResId")]
        public string ContractResId{ get; set; }

        /// <summary>
        /// 帐户ID
        /// </summary>
        [JsonProperty("AccountResId")]
        public string AccountResId{ get; set; }

        /// <summary>
        /// 授权时间，格式为年月日时分秒，例20160801095509
        /// </summary>
        [JsonProperty("AuthorizationTime")]
        public string AuthorizationTime{ get; set; }

        /// <summary>
        /// 授权IP地址
        /// </summary>
        [JsonProperty("Position")]
        public string Position{ get; set; }

        /// <summary>
        /// 签署坐标，坐标不得超过合同文件边界
        /// </summary>
        [JsonProperty("SignLocations")]
        public SignLocation[] SignLocations{ get; set; }

        /// <summary>
        /// 印章ID
        /// </summary>
        [JsonProperty("SealResId")]
        public string SealResId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ContractResId", this.ContractResId);
            this.SetParamSimple(map, prefix + "AccountResId", this.AccountResId);
            this.SetParamSimple(map, prefix + "AuthorizationTime", this.AuthorizationTime);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamArrayObj(map, prefix + "SignLocations.", this.SignLocations);
            this.SetParamSimple(map, prefix + "SealResId", this.SealResId);
        }
    }
}

