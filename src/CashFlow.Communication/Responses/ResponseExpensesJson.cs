using CashFlow.Communication.Enums;

namespace CashFlow.Communication.Responses
{
    public class ResponseExpensesJson
    {
        public List<ResponseShortExpenseJson> Expenses { get; set; } = [];
    }
}
