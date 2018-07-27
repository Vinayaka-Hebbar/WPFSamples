using System.Collections.Generic;

namespace WPFSamples.Common
{
    public interface IDirectory : IInfo
    {
        bool IsLoaded { get; set; }
        IList<IInfo> InfoList { get; }
        void Add(IInfo info);
    }
}
