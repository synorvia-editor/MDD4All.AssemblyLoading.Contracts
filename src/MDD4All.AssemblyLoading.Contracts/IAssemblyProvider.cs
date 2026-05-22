using System.Reflection;

namespace MDD4All.AssemblyLoading.Contracts
{
    public interface IAssemblyProvider
    {
        Assembly GetAssemblyByPath(string path);
    }
}
