using CoreBusiness;

namespace UseCases.UseCaseInterface
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}