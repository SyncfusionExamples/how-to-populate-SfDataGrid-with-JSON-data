﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GettingStarted
{
	public class OrderInfoRepository
	{
		private ObservableCollection<OrderInfo> orderInfo;

		public ObservableCollection<OrderInfo> OrderInfoCollection {
			get { return orderInfo; }
			set { this.orderInfo = value; }
		}

		public OrderInfoRepository ()
		{
			orderInfo = new ObservableCollection<OrderInfo> ();
			this.GenerateOrders ();
		}

		private void GenerateOrders ()
		{
            orderInfo.Add(new OrderInfo(0,1001, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfo(0,1002, "Ana Trujilo", "Mexico", "ANATR", "México D.F."));
            orderInfo.Add(new OrderInfo(0,1003, "Ant Fuller", "Mexico", "ANTON", "México D.F."));
            orderInfo.Add(new OrderInfo(0,1004, "Thomas Hardy", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(0,1005, "Tim Adams", "Sweden", "BERGS", "Luleå"));
            orderInfo.Add(new OrderInfo(0,1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(0,1007, "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(0,1008, "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo(0,1009, "Lenny Lin", "France", "BONAP", "Marseille"));
            orderInfo.Add(new OrderInfo(0,1010, "John Carter", "Canada", "BOTTM", "Tsawassen"));
            orderInfo.Add(new OrderInfo(0,1011, "Lauro King", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(0,1012, "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
                                        
            orderInfo.Add(new OrderInfo(0,1001, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfo(0,1002, "Ana Trujilo", "Mexico", "ANATR", "México D.F."));
            orderInfo.Add(new OrderInfo(0,1003, "Ant Fuller", "Mexico", "ANTON", "México D.F."));
            orderInfo.Add(new OrderInfo(0,1004, "Thomas Hardy", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(0,1005, "Tim Adams", "Sweden", "BERGS", "Luleå"));
            orderInfo.Add(new OrderInfo(0,1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(0,1007, "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(0,1008, "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo(0,1009, "Lenny Lin", "France", "BONAP", "Marseille"));
            orderInfo.Add(new OrderInfo(0,1010, "John Carter", "Canada", "BOTTM", "Tsawassen"));
            orderInfo.Add(new OrderInfo(0,1011, "Lauro King", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(0,1012, "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
                                        
            orderInfo.Add(new OrderInfo(0,1001, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfo(0,1002, "Ana Trujilo", "Mexico", "ANATR", "México D.F."));
            orderInfo.Add(new OrderInfo(0,1003, "Ant Fuller", "Mexico", "ANTON", "México D.F."));
            orderInfo.Add(new OrderInfo(0,1004, "Thomas Hardy", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(0,1005, "Tim Adams", "Sweden", "BERGS", "Luleå"));
            orderInfo.Add(new OrderInfo(0,1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(0,1007, "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(0,1008, "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo(0,1009, "Lenny Lin", "France", "BONAP", "Marseille"));
            orderInfo.Add(new OrderInfo(0,1010, "John Carter", "Canada", "BOTTM", "Tsawassen"));
            orderInfo.Add(new OrderInfo(0,1011, "Lauro King", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(0,1012, "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
        }
	}
}

