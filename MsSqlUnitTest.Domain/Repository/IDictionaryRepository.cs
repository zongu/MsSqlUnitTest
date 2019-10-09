
namespace MsSqlUnitTest.Domain.Repository
{
    using System;

    /// <summary>
    /// 表 Dictionary 行為介面
    /// </summary>
    public interface IDictionaryRepository
    {
        /// <summary>
        /// 新增資料到表 Dictionary
        /// </summary>
        /// <param name="dictionary">Dictionary資料</param>
        /// <returns></returns>
        Tuple<Exception, Model.Dictionary> Insert(Model.Dictionary dictionary);
    }
}
