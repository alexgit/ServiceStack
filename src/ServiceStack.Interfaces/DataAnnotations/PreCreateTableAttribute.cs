﻿using System;

namespace ServiceStack.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PreCreateTableAttribute : AttributeBase
    {
        public string Sql { get; set; }

        public PreCreateTableAttribute(string sql)
        {
            Sql = sql;
        }
    }
}