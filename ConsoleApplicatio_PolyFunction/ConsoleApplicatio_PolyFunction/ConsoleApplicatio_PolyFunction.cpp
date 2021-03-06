// ConsoleApplicatio_PolyFunction.cpp: 定义控制台应用程序的入口点。


#include "stdafx.h";
#include <runtime.h>

#define MAXN 100  //运行次数 
#define MAXK 1  //运行次数 



//逐项求

double f1(int n, double x)

{

	double y = 0;

	int i;

	for (i = 1; i <= n; i++)

		y += i * pow(x, i);

	return y;

}



//多项式结合

double f2(int n, double x)

{

	double y = n * x;

	for (n = n - 1; n>0; n--)

		y = x * (n + y);

	return y;

}



int main()

{

	clock_t start, end;//clock_t 是clock()函数返回的变量类型,本质是long

	double duration;//记录运行时间，以秒为单位

	double result;

	int i;

	int N = MAXN;



	//测试f1

	start = clock();

	//加大问题规模，再求平均值

	for (i = 0; i<MAXK; i++)

		result = f1(N, 1.1);

	end = clock();

	duration = compute_dur(start, end);//求duration的值，单位为秒

	printf("f1(x)逐项求和的时间%0.2E,结果：%lf\n", duration, result);



	//测试f2

	start = clock();

	//加大问题规模，再求平均值

	for (i = 0; i<MAXK; i++)

		result = f2(N, 1.1);

	end = clock();

	duration = compute_dur(start, end);//求duration的值，单位为秒;

	printf("f2(x)多项式展开求和的时间%0.2E，结果：%lf\n", duration, result);

	return 0;

}