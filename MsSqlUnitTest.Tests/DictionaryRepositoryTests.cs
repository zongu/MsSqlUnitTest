
namespace MsSqlUnitTest.Tests
{
    using System.Data.SqlClient;
    using Dapper;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MsSqlUnitTest.Domain.Model;
    using MsSqlUnitTest.Domain.Repository;
    using MsSqlUnitTest.Persistent;
    using MsSqlUnitTest.Tests.Applibs;

    [TestClass]
    public class DictionaryRepositoryTests
    {
        /// <summary>
        /// Dictionary 介面
        /// </summary>
        private IDictionaryRepository repo;

        /// <summary>
        /// 單元測試初始化
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            this.repo = new DictionaryRepository(ConfigHelper.ConnectionString);

            //// 清空表  確保每次跑單員測試都是乾淨的
            using (var cn = new SqlConnection(ConfigHelper.ConnectionString))
            {
                string sqlStr = @"TRUNCATE TABLE Dictionary";
                cn.Execute(sqlStr);
            }
        }

        [TestMethod]
        public void InsertTest()
        {
            var dic = new Dictionary()
            {
                DictionaryId = 1,
                Value = "Test123"
            };

            var insertResult = this.repo.Insert(dic);
            Assert.IsNull(insertResult.Item1);
            Assert.IsNotNull(insertResult.Item2);
            Assert.AreEqual(insertResult.Item2.DictionaryId, 1);
            Assert.AreEqual(insertResult.Item2.Value, "Test123");
        }
    }
}
