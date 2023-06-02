namespace ApplicationCoreMaui70.SeedWork;

/// <summary>
/// https://medium.com/c-sharp-progarmming/unit-of-work-design-pattern-in-c-a-practical-guide-for-developers-948474156837
/// </summary>
public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken));
}

