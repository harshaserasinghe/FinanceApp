using Finance.Core.DTOs;

namespace Finance.Service
{
    public interface ITransactionService
    {
        void AddTransaction(CreateTransactionDTO transactionDTO);
    }
}