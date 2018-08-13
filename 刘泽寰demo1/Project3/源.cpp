#include <iostream>
using namespace std;
int main()
{
	int f(int, int, int);
	int fac(int);
	int x, y, z;
	cin >> x >> y >> z;
	if (f(x, y, z) == 1)
	{
		if (fac(x) == 1)
		{
			switch (y)
			{
			case 1:cout << "你输入的日期是该年的第" << z << "天";break;
			case 2:cout << "你输入的日期是该年的第" << 31 + z << "天";break;
			case 3:cout << "你输入的日期是该年的第" << 60 + z << "天";break;
			case 4:cout << "你输入的日期是该年的第" << 91 + z << "天";break;
			case 5:cout << "你输入的日期是该年的第" << 121 + z << "天";break;
			case 6:cout << "你输入的日期是该年的第" << 152 + z << "天";break;
			case 7:cout << "你输入的日期是该年的第" << 182 + z << "天";break;
			case 8:cout << "你输入的日期是该年的第" << 213 + z << "天";break;
			case 9:cout << "你输入的日期是该年的第" << 244 + z << "天";break;
			case 10:cout << "你输入的日期是该年的第" << 274 + z << "天";break;
			case 11:cout << "你输入的日期是该年的第" << 305 + z << "天";break;
			case 12:cout << "你输入的日期是该年的第" << 335 + z << "天";break;
			}
		}
		else
		{
			switch (y)
			{
			case 1:cout << "你输入的日期是该年的第" << z << "天";break;
			case 2:cout << "你输入的日期是该年的第" << 31 + z << "天";break;
			case 3:cout << "你输入的日期是该年的第" << 59 + z << "天";break;
			case 4:cout << "你输入的日期是该年的第" << 90 + z << "天";break;
			case 5:cout << "你输入的日期是该年的第" << 120 + z << "天";break;
			case 6:cout << "你输入的日期是该年的第" << 151 + z << "天";break;
			case 7:cout << "你输入的日期是该年的第" << 181 + z << "天";break;
			case 8:cout << "你输入的日期是该年的第" << 212 + z << "天";break;
			case 9:cout << "你输入的日期是该年的第" << 243 + z << "天";break;
			case 10:cout << "你输入的日期是该年的第" << 274 + z << "天";break;
			case 11:cout << "你输入的日期是该年的第" << 305 + z << "天";break;
			case 12:cout << "你输入的日期是该年的第" << 335 + z << "天";break;
			}
		}
	}
	else
		cout << "您输入的年份不合法" << endl;
	system("pause");
	return 0;
}
int f(int a, int b, int c)
{
	if (a>0)
	{
		if (b >= 1 && b <= 12)
		{
			if (b != 2)
			{
				if (b == 1 || b == 3 || b == 5 || b == 7 || b == 8 || b == 10 || b == 12)
				{
					if (c >= 1 && c <= 31)
						return(1);
					else
						return(0);
				}
				else
				{
					if (c >= 1 && c <= 30)
						return(1);
					else
						return(0);
				}
			}
			else
			{
				int fac(int);
				if (fac(a) == 1)
				{
					if (c >= 1 && c <= 29)
						return(1);
					else
						return(0);
				}
				else
				{
					if (c >= 1 && c <= 28)
						return(1);
					else
						return(0);
				}
			}
		}
		else
			return(0);
	}
	else
		return(0);
}
int fac(int a)
{
	if (a % 4 == 0)
	{
		if (a % 100 == 0)
		{
			if (a % 400 == 0)
				return(1);
			else
				return(0);
		}
		else
			return(1);
	}
	else
		return(0);
}