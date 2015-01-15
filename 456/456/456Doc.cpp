// 456Doc.cpp : CMy456Doc 类的实现
//

#include "stdafx.h"
#include "456.h"

#include "456Doc.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CMy456Doc

IMPLEMENT_DYNCREATE(CMy456Doc, CDocument)

BEGIN_MESSAGE_MAP(CMy456Doc, CDocument)
END_MESSAGE_MAP()


// CMy456Doc 构造/析构

CMy456Doc::CMy456Doc()
{
	// TODO: 在此添加一次性构造代码

}

CMy456Doc::~CMy456Doc()
{
}

BOOL CMy456Doc::OnNewDocument()
{
	if (!CDocument::OnNewDocument())
		return FALSE;

	// TODO: 在此添加重新初始化代码
	// (SDI 文档将重用该文档)

	return TRUE;
}




// CMy456Doc 序列化

void CMy456Doc::Serialize(CArchive& ar)
{
	if (ar.IsStoring())
	{
		// TODO: 在此添加存储代码
	}
	else
	{
		// TODO: 在此添加加载代码
	}
}


// CMy456Doc 诊断

#ifdef _DEBUG
void CMy456Doc::AssertValid() const
{
	CDocument::AssertValid();
}

void CMy456Doc::Dump(CDumpContext& dc) const
{
	CDocument::Dump(dc);
}
#endif //_DEBUG


// CMy456Doc 命令
