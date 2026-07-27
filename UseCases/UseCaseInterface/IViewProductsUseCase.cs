using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterface
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}