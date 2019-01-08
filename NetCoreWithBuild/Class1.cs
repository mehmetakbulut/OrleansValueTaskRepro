using System;
using System.Threading.Tasks;
using Orleans;

namespace NetCoreWithBuild
{
    public interface IExampleGrain : IGrainWithGuidKey
    {
        ValueTask<bool> Test();
    }
}
