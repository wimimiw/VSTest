// 456View.h : CMy456View 类的接口
//


#pragma once


class CMy456View : public CView
{
protected: // 仅从序列化创建
	CMy456View();
	DECLARE_DYNCREATE(CMy456View)

// 属性
public:
	CMy456Doc* GetDocument() const;

// 操作
public:

// 重写
public:
	virtual void OnDraw(CDC* pDC);  // 重写以绘制该视图
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// 实现
public:
	virtual ~CMy456View();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// 生成的消息映射函数
protected:
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // 456View.cpp 中的调试版本
inline CMy456Doc* CMy456View::GetDocument() const
   { return reinterpret_cast<CMy456Doc*>(m_pDocument); }
#endif

