﻿using Dapper;

namespace SideBySide.New
{
    public class TransactionFixture : DatabaseFixture
    {
	    public TransactionFixture()
	    {
		    Connection.Open();
		    Connection.Execute(@"
drop schema if exists transactions;

create schema transactions;

create table transactions.test(value integer null);
			");
	    }
    }
}
