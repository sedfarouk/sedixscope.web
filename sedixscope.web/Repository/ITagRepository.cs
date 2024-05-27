using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sedixscope.web.Models.Domain;

namespace sedixscope.web.Repository
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllAsync();
        Task<Tag> GetAsync(Guid id);
        Task<Tag> AddAsync(Tag tag);
        Task<Tag> UpdateAsync(Tag tag);
        Task<Tag> DeleteAsync(Guid id);
    }
}