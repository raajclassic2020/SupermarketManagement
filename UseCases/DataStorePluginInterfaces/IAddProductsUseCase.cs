using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IAddProductsUseCase
    {
        void Execute(Product product);
    }
}