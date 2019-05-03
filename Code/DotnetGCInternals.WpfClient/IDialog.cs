using System.Threading.Tasks;

namespace DotnetGCInternals.WpfClient
{
    public interface IDialog
    {
        Task<bool> ShowDialogAsync();
    }
}