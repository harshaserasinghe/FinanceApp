using Finance.Core.DTOs;
using Finance.Core.Entities;
using System;
using System.Collections.Generic;

namespace Finance.Service
{
    public interface ITransactionService
    {
        void AddTransaction(CreateTransactionDTO createTransactionDTO);
        TransactionDTO GetTransaction(int transactionId);
        List<TransactionDTO> GetTransactionsByDate(TranType tranType, DateTime fromDate, DateTime toDate);
        void UpdateTransaction(int transactionId, UpdateTransactionDTO updateTransactionDTO);
    }
}