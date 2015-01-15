// 456View.cpp : CMy456View 类的实现
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
	// 标准打印命令
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CView::OnFilePrintPreview)
END_MESSAGE_MAP()

// CMy456View 构造/析构

CMy456View::CMy456View()
{
	// TODO: 在此处添加构造代码

}

CMy456View::~CMy456View()
{
}

BOOL CMy456View::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: 在此处通过修改
	//  CREATESTRUCT cs 来修改窗口类或样式

	return CView::PreCreateWindow(cs);
}

// CMy456View 绘制

void CMy456View::OnDraw(CDC* /*pDC*/)
{
	CMy456Doc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: 在此处为本机数据添加绘制代码
}


// CMy456View 打印

BOOL CMy456View::OnPreparePrinting(CPrintInfo* pInfo)
{
	// 默认准备
	return DoPreparePrinting(pInfo);
}

void CMy456View::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: 添加额外的打印前进行的初始化过程
}

void CMy456View::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: 添加打印后进行的清除过程
}


// CMy456View 诊断

#ifdef _DEBUG
void CMy456View::AssertValid() const
{
	CView::AssertValid();
}

void CMy456View::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CMy456Doc* CMy456View::GetDocument() const // 非调试版本是内联的
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CMy456Doc)));
	return (CMy456Doc*)m_pDocument;
}
#endif //_DEBUG


// CMy456View 消息处理程序
