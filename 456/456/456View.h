// 456View.h : CMy456View ��Ľӿ�
//


#pragma once


class CMy456View : public CView
{
protected: // �������л�����
	CMy456View();
	DECLARE_DYNCREATE(CMy456View)

// ����
public:
	CMy456Doc* GetDocument() const;

// ����
public:

// ��д
public:
	virtual void OnDraw(CDC* pDC);  // ��д�Ի��Ƹ���ͼ
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// ʵ��
public:
	virtual ~CMy456View();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// ���ɵ���Ϣӳ�亯��
protected:
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // 456View.cpp �еĵ��԰汾
inline CMy456Doc* CMy456View::GetDocument() const
   { return reinterpret_cast<CMy456Doc*>(m_pDocument); }
#endif

