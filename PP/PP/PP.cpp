// PP.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <windows.h>
int  CreateRun();


int _tmain(int argc, _TCHAR* argv[])
{
	/* 隐藏console  start */
	/*
	HWND hwnd;
	hwnd = FindWindow("ConsoleWindowClass", NULL);	//处理顶级窗口的类名和窗口名称匹配指定的字符串,不搜索子窗口。
	if (hwnd)
	{
	ShowWindow(hwnd, SW_HIDE);				//设置指定窗口的显示状态
	}
	//MessageBox(NULL, "Hello", "Notice", MB_OK);
	*/
	
	/* 隐藏console  end */


	// 主要
	HANDLE event1;
	HANDLE event2;
	HANDLE event3;
	STARTUPINFO si = { 0 };
	PROCESS_INFORMATION pi = { 0 };
	event1 = CreateEvent(NULL, FALSE, TRUE, "Global\\p1");// 安全属性、复位方式、初始状态、对象名称

	while (true)
	{
		if (!(event3 = OpenEvent(EVENT_MODIFY_STATE, FALSE, "Global\\p3")))
		{
			if (!CreateProcess("PP2.exe",
				NULL,
				NULL,
				NULL,
				NULL,
				CREATE_NEW_CONSOLE,
				NULL,
				NULL,
				&si,
				&pi
				))
			{
				printf("打开守护进程失败！\n");
			}
			else printf("打开守护进程成功！PID:%d \n", pi.dwProcessId);
			WaitForSingleObject(pi.hProcess, INFINITE);
			printf("守护进程被关闭！\n");
			CloseHandle(pi.hProcess);
		}
		CloseHandle(event3);
		Sleep(2000);
		/*
		if (!(event2 = OpenEvent(EVENT_MODIFY_STATE, FALSE, "Global\\p2")))
		{
			if (!CreateProcess("C:\\Users\\tabjin\\Desktop\\WindowsFormsApplication1.exe",
				NULL,
				NULL,
				NULL,
				NULL,
				CREATE_NEW_CONSOLE,
				NULL,
				NULL,
				&si,
				&pi
				))
			{
				printf("打开守护进程失败！\n");
			}
			else printf("打开守护进程成功啦！PID:%d \n", pi.dwProcessId);
			WaitForSingleObject(pi.hProcess, INFINITE);
			printf("守护进程被关闭！\n");
			CloseHandle(pi.hProcess);
		}
		CloseHandle(event2);
		Sleep(1000);
		*/
		
	}
	/*while (true)
	{
		if (!(event2 = OpenEvent(EVENT_MODIFY_STATE, FALSE, "Global\\p2")))
		{
			if (!CreateProcess("C:\\Users\\tabjin\\Desktop\\WindowsFormsApplication1.exe",
				NULL,
				NULL,
				NULL,
				NULL,
				CREATE_NEW_CONSOLE,
				NULL,
				NULL,
				&si,
				&pi
				))
			{
				printf("打开守护进程失败！\n");
			}
			else printf("打开守护进程成功！PID:%d \n", pi.dwProcessId);
			WaitForSingleObject(pi.hProcess, INFINITE);
			printf("守护进程被关闭！\n");
			CloseHandle(pi.hProcess);
		}
		CloseHandle(event2);
		Sleep(1000);
	}
	*/

	
	//CreateRun();
	return 0;
}

/******************************************************************************************
Function:        autostart
Description:     设置程序开机自启动
*******************************************************************************************/
//开机启动
int  CreateRun()
{
	//添加以下代码
	HKEY   hKey;
	char pFileName[MAX_PATH] = { 0 };
	//得到程序自身的全路径 
	DWORD dwRet = GetModuleFileNameW(NULL, (LPWCH)pFileName, MAX_PATH);
	//找到系统的启动项 
	LPCTSTR lpRun = _T("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
	//打开启动项Key 
	long lRet = RegOpenKeyEx(HKEY_LOCAL_MACHINE, lpRun, 0, KEY_WRITE, &hKey);
	if (lRet == ERROR_SUCCESS)
	{
		//添加注册
		RegSetValueEx(hKey, _T("WindowsFormsApplication1"), 0, REG_SZ, (const BYTE*)(LPCSTR)pFileName, MAX_PATH);
		RegCloseKey(hKey);
	}
	return 0;
}
//取消开机启动
int DeleteRun()
{
	//添加以下代码
	HKEY   hKey;
	char pFileName[MAX_PATH] = { 0 };
	//得到程序自身的全路径 
	DWORD dwRet = GetModuleFileNameW(NULL, (LPWCH)pFileName, MAX_PATH);
	//找到系统的启动项 
	LPCTSTR lpRun = _T("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
	//打开启动项Key 
	long lRet = RegOpenKeyEx(HKEY_LOCAL_MACHINE, lpRun, 0, KEY_WRITE, &hKey);
	if (lRet == ERROR_SUCCESS)
	{
		//删除注册
		RegDeleteValue(hKey, _T("WindowsFormsApplication1"));
		RegCloseKey(hKey);
	}
	return 0;
}

