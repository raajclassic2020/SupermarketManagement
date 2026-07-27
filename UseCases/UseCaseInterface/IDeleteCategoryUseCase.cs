using CoreBusiness;

namespace UseCases.UseCaseInterface
{
    public interface IDeleteCategoryUseCase
    {
        void Execute(int categoryId);
    }
}