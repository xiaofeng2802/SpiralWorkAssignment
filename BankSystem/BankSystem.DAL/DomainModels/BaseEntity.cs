﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BankSystem.DAL.DomainModels
{
    public class BaseEntity<TKey> where TKey: struct
    {
        public TKey Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
