namespace FlightWizard.Business;
public interface IRepository<TEntity>
{
	public List<TEntity> Get();
	public TEntity? GetById(int id);
	public bool Delete(int id);
	public bool Update(TEntity entity);
	public bool Insert(TEntity entity);
}
