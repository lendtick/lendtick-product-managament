using Lendtick.Product.Business.Retriever;
using Lendtick.Product.Business.Validator;
using Lendtick.Product.Common;
using Lendtick.Product.Data.Entity.Mongo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Business.Business
{
    public class CategoryManager : ICategoryManager
    {
        #region Property
        public string ParentCategory { get; private set; }
        public IEnumerable<Category> Categories { get; private set; }
        #endregion

        #region CTOR
        public CategoryManager() { }
        public CategoryManager(string parentCategory)
        {
            this.ParentCategory = parentCategory;
        }
        #endregion

        #region Implemented Method
        public async Task<IResultStatus> GetFirstCategory()
        {
            IResultStatus result = new ResultStatus();
            ICategoryRetriever retriever = new FirstCategoryRetriever();

            this.Categories = await retriever.Retrieve();

            IBaseValidator validator = new CategoryValidator(this.Categories);
            result = validator.Validate();

            return result;
        }

        public async Task<IResultStatus> GetSecondCategory()
        {
            IResultStatus result = new ResultStatus();
            ICategoryRetriever retriever = new SecondCategoryRetriever(this.ParentCategory);

            this.Categories = await retriever.Retrieve();

            IBaseValidator validator = new CategoryValidator(this.Categories);
            result = validator.Validate();

            return result;
        }

        public async Task<IResultStatus> GetThirdCategory()
        {
            IResultStatus result = new ResultStatus();
            ICategoryRetriever retriever = new ThirdCategoryRetriever(this.ParentCategory);

            this.Categories = await retriever.Retrieve();

            IBaseValidator validator = new CategoryValidator(this.Categories);
            result = validator.Validate();

            return result;
        } 
        #endregion
    }
}