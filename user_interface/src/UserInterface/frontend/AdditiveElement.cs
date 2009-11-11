////////////////////////////////////////////////////////////////////////
// AdditionOperationElement.java: holds the data needed for an addition 
//  operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: vinit mehta
// language: CSHARP
////////////////////////////////////////////////////////////////////////
//#define TEST_ADDITION
public class AdditiveElement : Element {

  Element mLhs;
  Element mRhs;  

  public override void Accept(Visitor visitor){
    visitor.VisitAdditionOperationElement(this);
  }

  public Element getLhs() { return mLhs; }
  public void setLhs(Element lhs) { mLhs = lhs; }

  public Element getRhs() { return mRhs; }
  public void setRhs(Element rhs) { mRhs = rhs; }
}
#if(TEST_ADDITION)

    //---------------< test stub >--------------------------------------------
class Test
{
    
    static void Main()
    {
        AdditiveElement add = new AdditiveElement();
        IntegerElement a = new IntegerElement();
        IntegerElement b = new IntegerElement();
        
        a.setText("5");

        b.setText("5");
        add.setLhs(a);
       add.setRhs(b);
      Element c ;
      Element d ;
        c = (Element)add.getLhs();
        d = (Element)add.getRhs();
    }
}
#endif