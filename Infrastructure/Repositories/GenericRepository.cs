using ApplicationCore.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{

    internal IUnitOfWork<T> _unitOfWork;

    public GenericRepository(IUnitOfWork<T> unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


   
    public virtual async Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();

    }

    public virtual async Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

}
