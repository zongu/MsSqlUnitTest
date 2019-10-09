
namespace MsSqlUnitTest.Persistent
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using Dapper;
    using MsSqlUnitTest.Domain.Model;
    using MsSqlUnitTest.Domain.Repository;

    /// <summary>
    /// 表 Dictionary 行為實例
    /// </summary>
    public class DictionaryRepository : IDictionaryRepository
    {
        /// <summary>
        /// 連線字串
        /// </summary>
        private string connectionString;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="connectionString">連線字串</param>
        public DictionaryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// 新增資料到表 Dictionary
        /// </summary>
        /// <param name="dictionary">Dictionary資料</param>
        /// <returns></returns>
        public Tuple<Exception, Dictionary> Insert(Dictionary dictionary)
        {
            try
            {
                using (var cn = new SqlConnection(this.connectionString))
                {
                    var result = cn.QueryFirstOrDefault<Dictionary>(
                        "NSP_Dictionary_Insert",
                        dictionary,
                        commandType: CommandType.StoredProcedure);

                    return Tuple.Create<Exception, Dictionary>(null, result);
                }
            }
            catch (Exception ex)
            {
                return Tuple.Create<Exception, Dictionary>(ex, null);
            }
        }
    }
}
