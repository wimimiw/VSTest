// 456Doc.cpp : CMy456Doc ���ʵ��
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


// CMy456Doc ����/����

CMy456Doc::CMy456Doc()
{
	// TODO: �ڴ����һ���Թ������

}

CMy456Doc::~CMy456Doc()
{
}

BOOL CMy456Doc::OnNewDocument()
{
	if (!CDocument::OnNewDocument())
		return FALSE;

	// TODO: �ڴ�������³�ʼ������
	// (SDI �ĵ������ø��ĵ�)

	return TRUE;
}




// CMy456Doc ���л�

void CMy456Doc::Serialize(CArchive& ar)
{
	if (ar.IsStoring())
	{
		// TODO: �ڴ���Ӵ洢����
	}
	else
	{
		// TODO: �ڴ���Ӽ��ش���
	}
}


// CMy456Doc ���

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


// CMy456Doc ����
