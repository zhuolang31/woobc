namespace Wbc.Domain
{
	public interface IEntity<out TId>
    {
        TId Id { get; }
    }
}
