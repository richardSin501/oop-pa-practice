﻿using System;

namespace KitchenManagement
{
	public abstract class Employee
	{
		public string Name { get; }
		public DateTime BirtDate { get; }
		public Kitchen MyKitchen { get; }

		private int _salary;

		public int Salary
		{
			get => _salary;
			set
			{
				if (value >= 0) _salary = value;
				else
				{
					throw new ArgumentOutOfRangeException(nameof(value), "Salary needs to be more than 0!");
				}
			}
		}

		protected Employee(Kitchen myKitchen, int salary, string name, DateTime birtDate)
		{
			MyKitchen = myKitchen;
			_salary = salary;
			Name = name;
			BirtDate = birtDate;
		}

		protected void Yell(string sentence)
		{
			Console.WriteLine($"{Name}, {this.GetType().Name} yells: {sentence}");
		}

		public void TaxReport()
		{
			var tax = 0.99 * Salary;
			Yell($"My tax is {tax}");
		}
	}
}