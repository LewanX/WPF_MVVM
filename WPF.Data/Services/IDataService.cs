using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Practice2.Model;

namespace WPF_Practice2.Services
{
    public interface IDataService<T>where T : class
    {
        Task<ObservableCollection<T>> GetAllAsync();
        Task<T> Create(T entity);
        Task<T> GetById(int id);
        Task<T> Update(T typeClass);
        Task<bool> Delete(int id);

    }
}
