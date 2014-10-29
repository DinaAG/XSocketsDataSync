using DataSyncSample.Web.XSockets.DataSync;
using XSockets.Plugin.Framework.Attributes;

namespace DataSyncSample.Web.XSockets
{
    /// <summary>
    /// Implement extra methods or override datasync methods if needed
    /// </summary>
    [XSocketMetadata("Fruits")]
    public class FruitsController : XSocketsDataSyncController<FruitsController>
    {
        
    }
}
