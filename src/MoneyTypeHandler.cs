using Dapper;
using System.Data;

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
