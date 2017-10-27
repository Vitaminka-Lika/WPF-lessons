using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspyBankCredit
{
    public class Request
    {
        public User Borrower { get; set; } //Заемщик
        public int AmountOfCredit { get; set; } //Размер кредита
        public int LoanRepaymentPeriod { get; set; } //Срок выплаты
        public double InitialFee { get; set; } //Первоначальный взнос
        public bool IsApproved { get; set; }// Одобрена ли заявка
    }
}
