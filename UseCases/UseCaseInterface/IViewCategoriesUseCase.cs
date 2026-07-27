using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterface
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}