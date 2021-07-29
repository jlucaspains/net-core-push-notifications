using CorePush.Apple;
using System.Threading;
using System.Threading.Tasks;

namespace CorePush.Interfaces
{
    public interface IApnSender
    {
        Task<ApnsResponse> SendAsync(
            ApnSettings settings,
            object notification,
            string deviceToken,
            string apnsId = null,
            int apnsExpiration = 0,
            int apnsPriority = 10,
            bool isBackground = false,
            CancellationToken cancellationToken = default);
    }
}