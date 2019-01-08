using System.Threading.Tasks;
using Orleans;

namespace NetStandardWithBuild
{
    public interface IExampleGrain : IGrainWithGuidKey
    {
        ValueTask<bool> Test();
    }
}
