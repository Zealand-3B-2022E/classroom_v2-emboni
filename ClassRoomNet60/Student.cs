using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Student
    {
		private string name;

		public string MyProperty
		{
			get { return name; }
			set { name = value; }
		}

		private int birthmonth;

		public int MyBirthProperty
		{
			get { return birthmonth; }
			set { birthmonth = value; }
		}

		private int birthday;

		public int MyBirthdayProperty
		{
			get { return birthday; }
			set { birthday = value; }
		}

		public Student(string name, string myProperty, int birthmonth, int myBirthProperty, int birthday, int myBirthdayProperty)
		{
			this.name = name;
			MyProperty = myProperty;
			this.birthmonth = birthmonth;
			MyBirthProperty = myBirthProperty;
			this.birthday = birthday;
			MyBirthdayProperty = myBirthdayProperty;
		}
	}
}
