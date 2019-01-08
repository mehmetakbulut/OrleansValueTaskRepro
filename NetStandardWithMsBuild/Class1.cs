using System;
using System.Threading.Tasks;
using Orleans;

namespace NetStandardWithMsBuild
{
    public interface IExampleGrain : IGrainWithGuidKey
    {
        ValueTask<bool> Test();
    }
}
