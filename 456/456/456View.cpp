// 456View.cpp : CMy456View ���ʵ��
//

#include "stdafx.h"
#include "456.h"

#include "456Doc.h"
#include "456View.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CMy456View

IMPLEMENT_DYNCREATE(CMy456View, CView)

BEGIN_MESSAGE_MAP(CMy456View, CView)
	// ��׼��ӡ����
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CView::OnFilePrintPreview)
END_MESSAGE_MAP()

// CMy456View ����/����

CMy456View::CMy456View()
{
	// TODO: �ڴ˴���ӹ������

}

CMy456View::~CMy456View()
{
}

BOOL CMy456View::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: �ڴ˴�ͨ���޸�
	//  CREATESTRUCT cs ���޸Ĵ��������ʽ

	return CView::PreCreateWindow(cs);
}

// CMy456View ����

void CMy456View::OnDraw(CDC* /*pDC*/)
{
	CMy456Doc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: �ڴ˴�Ϊ����������ӻ��ƴ���
}


// CMy456View ��ӡ

BOOL CMy456View::OnPreparePrinting(CPrintInfo* pInfo)
{
	// Ĭ��׼��
	return DoPreparePrinting(pInfo);
}

void CMy456View::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: ��Ӷ���Ĵ�ӡǰ���еĳ�ʼ������
}

void CMy456View::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: ��Ӵ�ӡ����е��������
}


// CMy456View ���

#ifdef _DEBUG
void CMy456View::AssertValid() const
{
	CView::AssertValid();
}

void CMy456View::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CMy456Doc* CMy456View::GetDocument() const // �ǵ��԰汾��������
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CMy456Doc)));
	return (CMy456Doc*)m_pDocument;
}
#endif //_DEBUG


// CMy456View ��Ϣ�������
