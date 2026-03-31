namespace CoreService.Application.Interfaces;

public interface IUsersServiceClient
{
    Task<bool> UserExistsAsync(Guid userId, CancellationToken cancellationToken = default);
}
