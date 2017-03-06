using System;
using System.Text;
using Owen.Site.Model;
using Owen.Site.Resouce;
using Owen.Site.Core.Http;
using Owen.Site.Core.Common;
using System.Collections.Generic;
using Owen.Site.Reference.Service.Solr;
using Owen.Site.Reference.Service.Imp.ReferenceModel;

namespace Owen.Site.Reference.Service.Imp.Solr
{
    public class ScheduleReferenceImp : IScheduleReferenceService
    {
        public List<ScheduleInfo> GetScheduleInfo(ScheduleQuery info)
        {
            //string url = ConfigurationService.GetAppSetting<string>("ScheduleSorlUrl");
            string url = "http://localhost:8080/solr/JobScheduler/select";

            if (string.IsNullOrEmpty(url))
                throw new Exception("please config 'ScheduleSorlUrl' in AppSetting");

            string mustStr = "?indent=on&wt=json";
            var queryStr = ConstructSelectStr(info);
            var requstUrl = string.Format("{0}{1}&{2}", url, mustStr, queryStr);

            var request = new HttpRestClient(
                new System.Net.WebHeaderCollection { 
                    {"Accept", ContentFormat.Json},
                    {"Content-Type", ContentFormat.Json}
            });

            var result = 
                request.PostByStrService<ScheduleResponse>(requstUrl, "GET");

            return null;
        }

        private string ConstructSelectStr(ScheduleQuery info)
        {
            var resultStr = new StringBuilder("q=*:*");

            if (info.IdList != null && info.IdList.Count > 0)
            {
                resultStr.Append("+AND+Id:(");
                resultStr.AppendFormat(string.Join("+OR+", info.IdList));
                resultStr.Append(")");
            }

            if (info.BeginStartTime.HasValue)
            {
                resultStr.AppendFormat("+AND+StartTime:[\"{0}\"+TO+*]", info.BeginStartTime.Value.ToString(BusinessError.DataFormat_Solr));
            }

            if (info.EndStartTime.HasValue)
            {
                resultStr.AppendFormat("+AND+StartTime:[*TO+\"{0}\"]", info.EndStartTime.Value.ToString(BusinessError.DataFormat_Solr));
            }

            if (info.BeginOverTime.HasValue)
            {
                resultStr.AppendFormat("+AND+EndTime:[\"{0}\"+TO+*]", info.BeginOverTime.Value.ToString(BusinessError.DataFormat_Solr));
            }

            if (info.EndOverTime.HasValue)
            {
                resultStr.AppendFormat("+AND+EndTime:[\"{0}\"+TO+*]", info.EndOverTime.Value.ToString(BusinessError.DataFormat_Solr));
            }

            resultStr.AppendFormat("&start={0}", (info.PageInfo.PageIndex - 1) * info.PageInfo.PageSize);
            resultStr.AppendFormat("&rows={0}", info.PageInfo.PageSize);
            resultStr.AppendFormat("&sort={0}", "Id+desc");

            resultStr.AppendFormat("&fl={0}", "Id,StartTime,EndTime,ExitCode,Pid");

            return resultStr.ToString();
        }
    }
}
