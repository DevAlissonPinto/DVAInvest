namespace DVAInvest.Domain.Interfaces;

public interface IUnitOfWork<TContext>
{
    int Commit();
}
