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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpotMarketOptions : AbstractModel
    {
        
        /// <summary>
        /// 竞价出价
        /// </summary>
        [JsonProperty("MaxPrice")]
        public string MaxPrice{ get; set; }

        /// <summary>
        /// 竞价请求类型，当前仅支持类型：one-time
        /// </summary>
        [JsonProperty("SpotInstanceType")]
        public string SpotInstanceType{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxPrice", this.MaxPrice);
            this.SetParamSimple(map, prefix + "SpotInstanceType", this.SpotInstanceType);
        }
    }
}

