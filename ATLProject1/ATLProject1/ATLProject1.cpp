// ATLProject1.cpp : Implementation of WinMain


#include "stdafx.h"
#include "resource.h"
#include "ATLProject1_i.h"


using namespace ATL;


class CATLProject1Module : public ATL::CAtlExeModuleT< CATLProject1Module >
{
public :
	DECLARE_LIBID(LIBID_ATLProject1Lib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_ATLPROJECT1, "{D1E526E5-5D7F-4594-97B7-9570C1EB8D9B}")
	};

CATLProject1Module _AtlModule;



//
extern "C" int WINAPI _tWinMain(HINSTANCE /*hInstance*/, HINSTANCE /*hPrevInstance*/, 
								LPTSTR /*lpCmdLine*/, int nShowCmd)
{
	return _AtlModule.WinMain(nShowCmd);
}

