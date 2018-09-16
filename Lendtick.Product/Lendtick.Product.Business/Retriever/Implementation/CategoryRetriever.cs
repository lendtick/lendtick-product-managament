using Lendtick.Product.Data.Entity.Mongo;
using Lendtick.Product.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Business.Retriever
{
    internal class FirstCategoryRetriever : BaseRetriever, ICategoryRetriever
    {
        #region CTOR
        public FirstCategoryRetriever() { }
        #endregion

        #region Implementation
        public async Task<IEnumerable<Category>> Retrieve()
        {
            ICategoryRepository repo = new CategoryRepository();
            return await repo.GetFirstCategory();
        } 
        #endregion
    }

    internal class SecondCategoryRetriever : BaseRetriever, ICategoryRetriever
    {
        #region Property
        public string ParentCategory { get; private set; }
        #endregion

        #region CTOR
        public SecondCategoryRetriever(string parentCategory)
        {
            this.ParentCategory = parentCategory;
        }
        #endregion

        #region Implementation
        public async Task<IEnumerable<Category>> Retrieve()
        {
            ICategoryRepository repo = new CategoryRepository(this.ParentCategory);
            return await repo.GetSecondCategory();
        } 
        #endregion
    }

    internal class ThirdCategoryRetriever : BaseRetriever, ICategoryRetriever
    {
        #region Property
        public string ParentCategory { get; private set; }
        #endregion

        #region CTOR
        public ThirdCategoryRetriever(string parentCategory)
        {
            this.ParentCategory = parentCategory;
        }
        #endregion

        #region Implementation
        public async Task<IEnumerable<Category>> Retrieve()
        {
            ICategoryRepository repo = new CategoryRepository(this.ParentCategory);
            return await repo.GetThirdCategory();
        } 
        #endregion
    }
}