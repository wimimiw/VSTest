// 456Doc.h : CMy456Doc ��Ľӿ�
//


#pragma once


class CMy456Doc : public CDocument
{
protected: // �������л�����
	CMy456Doc();
	DECLARE_DYNCREATE(CMy456Doc)

// ����
public:

// ����
public:

// ��д
public:
	virtual BOOL OnNewDocument();
	virtual void Serialize(CArchive& ar);

// ʵ��
public:
	virtual ~CMy456Doc();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// ���ɵ���Ϣӳ�亯��
protected:
	DECLARE_MESSAGE_MAP()
};


