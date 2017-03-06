using System;
using System.Linq;
using Owen.Site.Main.Service;
using Owen.Site.Services.BaiduMap;

namespace Owen.Site.Services.Service.BaiduMap
{
    public class BaiduMapService : ServiceStack.Service
    {
        public IMapDomainService mapService { get; set; }

        public object Get(MapInfoServiceRequest request)
        {
            return mapService.GetMapList();
        }

        public object Post(MapInfoServiceRequest req)
        {
            //throw new BussinessException("adasdfsdf: {0}".Fmt(req.Address));
            //this.Request.Files[0].SaveTo("path"); save file
            return new
            {
                Address = req.Address,
                XPoint = req.XPoint,
                YPoint = req.YPoint,
                Action = req.Action,
                test = req.test
            };
        }

        public object Post(JobSheduler req)
        {
            var result = mapService.GetJobSchedulerInfoList();
            return result.Select(item => new
            {
                Pid = item.Pid,
                Id = item.Id,
                StartTime = item.StartTime.ToString("yyyy-MM-dd hh:mm:ss"),
                EndTime = item.EndTime.ToString("yyyy-MM-dd hh:mm:ss"),
                ExitCode = item.ExitCode
            });
        }
    }
}
