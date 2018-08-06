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

    public class CreateEnterpriseAccountRequest : AbstractModel
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
        /// 企业用户名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 企业用户证件类型，8代表营业执照
        /// </summary>
        [JsonProperty("IdentType")]
        public long? IdentType{ get; set; }

        /// <summary>
        /// 企业用户营业执照号码
        /// </summary>
        [JsonProperty("IdentNo")]
        public string IdentNo{ get; set; }

        /// <summary>
        /// 企业联系电话
        /// </summary>
        [JsonProperty("MobilePhone")]
        public string MobilePhone{ get; set; }

        /// <summary>
        /// 经办人姓名
        /// </summary>
        [JsonProperty("TransactorName")]
        public string TransactorName{ get; set; }

        /// <summary>
        /// 经办人证件类型，0代表身份证
        /// </summary>
        [JsonProperty("TransactorIdentType")]
        public long? TransactorIdentType{ get; set; }

        /// <summary>
        /// 经办人证件号码
        /// </summary>
        [JsonProperty("TransactorIdentNo")]
        public string TransactorIdentNo{ get; set; }

        /// <summary>
        /// 经办人手机号
        /// </summary>
        [JsonProperty("TransactorPhone")]
        public string TransactorPhone{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdentType", this.IdentType);
            this.SetParamSimple(map, prefix + "IdentNo", this.IdentNo);
            this.SetParamSimple(map, prefix + "MobilePhone", this.MobilePhone);
            this.SetParamSimple(map, prefix + "TransactorName", this.TransactorName);
            this.SetParamSimple(map, prefix + "TransactorIdentType", this.TransactorIdentType);
            this.SetParamSimple(map, prefix + "TransactorIdentNo", this.TransactorIdentNo);
            this.SetParamSimple(map, prefix + "TransactorPhone", this.TransactorPhone);
        }
    }
}

