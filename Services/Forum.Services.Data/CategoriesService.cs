namespace Forum.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Forum.Data.Common.Repositories;
    using Forum.Data.Models;
    using Forum.Services.Mapping;

    public class CategoriesService : ICategoryService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Category> query = this.categoriesRepository.All().OrderBy(x => x.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }

        public List<Category> SearchCategory(string search)
        {
            return this.categoriesRepository.All().Where(x => x.Name.Contains(search)).ToList();
        }

        public IEnumerable<T> SearchCategory<T>(string search)
        {
            IQueryable<Category> query = this.categoriesRepository.All().Where(x => x.Name.Contains(search));

            return query.To<T>().ToList();
        }
    }
}
