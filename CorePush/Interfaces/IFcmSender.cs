using CorePush.Google;
using System.Threading;
using System.Threading.Tasks;

namespace CorePush.Interfaces
{
    public interface IFcmSender
    {
        Task<FcmResponse> SendAsync(FcmSettings settings, string deviceId, object payload, CancellationToken cancellationToken = default);
        Task<FcmResponse> SendAsync(FcmSettings settings, object payload, CancellationToken cancellationToken = default);
    }
}