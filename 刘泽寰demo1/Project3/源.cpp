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
			case 1:cout << "������������Ǹ���ĵ�" << z << "��";break;
			case 2:cout << "������������Ǹ���ĵ�" << 31 + z << "��";break;
			case 3:cout << "������������Ǹ���ĵ�" << 60 + z << "��";break;
			case 4:cout << "������������Ǹ���ĵ�" << 91 + z << "��";break;
			case 5:cout << "������������Ǹ���ĵ�" << 121 + z << "��";break;
			case 6:cout << "������������Ǹ���ĵ�" << 152 + z << "��";break;
			case 7:cout << "������������Ǹ���ĵ�" << 182 + z << "��";break;
			case 8:cout << "������������Ǹ���ĵ�" << 213 + z << "��";break;
			case 9:cout << "������������Ǹ���ĵ�" << 244 + z << "��";break;
			case 10:cout << "������������Ǹ���ĵ�" << 274 + z << "��";break;
			case 11:cout << "������������Ǹ���ĵ�" << 305 + z << "��";break;
			case 12:cout << "������������Ǹ���ĵ�" << 335 + z << "��";break;
			}
		}
		else
		{
			switch (y)
			{
			case 1:cout << "������������Ǹ���ĵ�" << z << "��";break;
			case 2:cout << "������������Ǹ���ĵ�" << 31 + z << "��";break;
			case 3:cout << "������������Ǹ���ĵ�" << 59 + z << "��";break;
			case 4:cout << "������������Ǹ���ĵ�" << 90 + z << "��";break;
			case 5:cout << "������������Ǹ���ĵ�" << 120 + z << "��";break;
			case 6:cout << "������������Ǹ���ĵ�" << 151 + z << "��";break;
			case 7:cout << "������������Ǹ���ĵ�" << 181 + z << "��";break;
			case 8:cout << "������������Ǹ���ĵ�" << 212 + z << "��";break;
			case 9:cout << "������������Ǹ���ĵ�" << 243 + z << "��";break;
			case 10:cout << "������������Ǹ���ĵ�" << 274 + z << "��";break;
			case 11:cout << "������������Ǹ���ĵ�" << 305 + z << "��";break;
			case 12:cout << "������������Ǹ���ĵ�" << 335 + z << "��";break;
			}
		}
	}
	else
		cout << "���������ݲ��Ϸ�" << endl;
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