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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeCdnDomainLogsResponseUnmarshaller
    {
        public static DescribeCdnDomainLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnDomainLogsResponse describeCdnDomainLogsResponse = new DescribeCdnDomainLogsResponse();

			describeCdnDomainLogsResponse.HttpResponse = context.HttpResponse;
			describeCdnDomainLogsResponse.RequestId = context.StringValue("DescribeCdnDomainLogs.RequestId");
			describeCdnDomainLogsResponse.PageNumber = context.LongValue("DescribeCdnDomainLogs.PageNumber");
			describeCdnDomainLogsResponse.PageSize = context.LongValue("DescribeCdnDomainLogs.PageSize");
			describeCdnDomainLogsResponse.TotalCount = context.LongValue("DescribeCdnDomainLogs.TotalCount");

			DescribeCdnDomainLogsResponse.DomainLogModel_ domainLogModel = new DescribeCdnDomainLogsResponse.DomainLogModel_();
			domainLogModel.DomainName = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainName");

			List<DescribeCdnDomainLogsResponse.DomainLogModel_.DomainLogDetail> domainLogDetails = new List<DescribeCdnDomainLogsResponse.DomainLogModel_.DomainLogDetail>();
			for (int i = 0; i < context.Length("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails.Length"); i++) {
				DescribeCdnDomainLogsResponse.DomainLogModel_.DomainLogDetail domainLogDetail = new DescribeCdnDomainLogsResponse.DomainLogModel_.DomainLogDetail();
				domainLogDetail.LogName = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].LogName");
				domainLogDetail.LogPath = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].LogPath");
				domainLogDetail.LogSize = context.LongValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].LogSize");
				domainLogDetail.StartTime = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].StartTime");
				domainLogDetail.EndTime = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].EndTime");

				domainLogDetails.Add(domainLogDetail);
			}
			domainLogModel.DomainLogDetails = domainLogDetails;
			describeCdnDomainLogsResponse.DomainLogModel = domainLogModel;
        
			return describeCdnDomainLogsResponse;
        }
    }
}