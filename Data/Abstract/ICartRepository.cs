using Entity;

namespace Data.Abstract
{
    public interface ICartRepository
    {
        List<Cart> GetAll();

        void Add(Cart cart);

        void Remove(int Id);

        void Update(Cart cart);
    }
}
