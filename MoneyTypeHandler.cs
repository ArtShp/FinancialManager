using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal class MoneyTypeHandler : SqlMapper.TypeHandler<MoneyModel>
    {
        public override MoneyModel Parse(object value)
        {
            return new MoneyModel(Convert.ToInt64(value.ToString()));
        }

        public override void SetValue(IDbDataParameter parameter, MoneyModel value)
        {
            parameter.Value = value.GetLong();
        }
    }
}
