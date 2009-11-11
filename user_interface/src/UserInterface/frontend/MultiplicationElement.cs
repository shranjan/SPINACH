////////////////////////////////////////////////////////////////////////
// MultiplicationOperationElement.cs: holds the data needed for an Multiplication
//  operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: vinit mehta
// language: Java 1.6.0.0
////////////////////////////////////////////////////////////////////////
//#define TEST_Multiplication
public class MultiplicationElement : Element
{

    Element mLhs;
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMultiplicationElement(this);
    }

    public Element getLhs() { return mLhs; }
    public void setLhs(Element lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(Element rhs) { mRhs = rhs; }
}

#if(TEST_Multiplication)

    //---------------< test stub >--------------------------------------------
class test
{
    [STAThread]
    static void Main()
    {
        MultiplicationElement mul = new MultiplicationElement();
        IntegerElement a = new IntegerElement();
        IntegerElement b = new IntegerElement();
        
        a.setText("5");

        b.setText("5");
        mul.setLhs(a);
       mul.setRhs(b);
      Element c ;
      Element d ;
        c = (Element)mul.getLhs();
        d = (Element)mul.getRhs();
    } 
}  
#endif