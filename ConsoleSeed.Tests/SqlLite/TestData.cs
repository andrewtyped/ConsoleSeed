using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeed.Tests.SqlLite
{
    internal static class TestData
    {
        public static void InsertTestData(ISession session)
        {
            using (var tx = session.BeginTransaction())
            {
                tx.Commit();
            }

            session.Clear();
        }
    }
}
