﻿using CashFlow.Domain.Reports;
using CashFlow.Domain.Enums;

namespace CashFlow.Domain.Extensions
{
    public static class PaymentTypeExtensions
    {
        public static string PaymentTypeToString(this PaymentType paymentType)
        {
            return paymentType switch
            {
                PaymentType.Cash => ResourceReportGenerationMessages.CASH,
                PaymentType.CreditCard => ResourceReportGenerationMessages.CREDIT_CARD,
                PaymentType.DebitCard => ResourceReportGenerationMessages.DEBIT_CARD,
                PaymentType.ElectronicTransfer => ResourceReportGenerationMessages.ELECTRONIC_TRANSFER,
                _ => string.Empty,
            };
        }
    }
}
