﻿using Aula1_Heranca.Entities;
using System;
using System.Reflection.Metadata;

namespace Aula2_Upcasting_Downcasting.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance / InterestRate;
        }
    }
}
