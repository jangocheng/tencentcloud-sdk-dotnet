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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogFileInfo : AbstractModel
    {
        
        /// <summary>
        /// Log最后修改时间
        /// </summary>
        [JsonProperty("Mtime")]
        public ulong? Mtime{ get; set; }

        /// <summary>
        /// 文件长度
        /// </summary>
        [JsonProperty("Length")]
        public ulong? Length{ get; set; }

        /// <summary>
        /// 下载Log时用到的统一资源标识符
        /// </summary>
        [JsonProperty("Uri")]
        public ulong? Uri{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mtime", this.Mtime);
            this.SetParamSimple(map, prefix + "Length", this.Length);
            this.SetParamSimple(map, prefix + "Uri", this.Uri);
        }
    }
}

