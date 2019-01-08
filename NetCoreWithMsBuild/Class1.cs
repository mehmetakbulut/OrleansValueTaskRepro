using System;
using System.Threading.Tasks;
using Orleans;

namespace NetCoreWithMsBuild
{
    public interface IExampleGrain : IGrainWithGuidKey
    {
        ValueTask<bool> Test();
    }
}
