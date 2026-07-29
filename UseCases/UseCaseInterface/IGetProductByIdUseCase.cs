using CoreBusiness;

namespace UseCases.UseCaseInterface
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}