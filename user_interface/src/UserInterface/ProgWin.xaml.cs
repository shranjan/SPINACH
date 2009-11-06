//////////////////////////////////////////////////////////////////////////////////
//  ProgWin.xaml.cs - Program Editor                                            //
//  ver 1.0                                                                     //
//                                                                              //
//  Language:      C#                                                           //
//  Platform:      Windows Vista                                                //
//  Application:   SPINACH                                                      //
//  Author:        Arunkumar K T (akyasara@syr.edu)                             //
//                 (315) 751 7324                                               //
//////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
namespace UserInterface
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ProgWin : Window
    {
        private ErrorModule err = new ErrorModule();
        private List<string> swarmUserList;
        private List<string> progUserList;
        public editorType et;

        public enum editorType { owner, collaborator };

        //this is to know the type of invocation

        public ProgWin()
        {
            InitializeComponent();
            err.ProgWinError+=new ErrorNotification(ShowError);
        }

        public ProgWin(editorType e)
        {
            InitializeComponent();
            et = e;
            err.ProgWinError += new ErrorNotification(ShowError);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void mnuFile_Click(object sender, RoutedEventArgs e)
        {
            mnuSave.Visibility = Visibility.Visible;
            mnuExit.Visibility = Visibility.Visible;
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void mnuWrap_Click(object sender, RoutedEventArgs e)
        {   
            if (rtbInput.HorizontalScrollBarVisibility == ScrollBarVisibility.Disabled)
            {
                rtbInput.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
                rtbInput.Document.PageWidth =20000;
                LineNumbers();
                syntax();
            }
            else
            {
                rtbInput.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
                rtbInput.Document.PageWidth = rtbInput.Width;
                LineNumbers();
                syntax();
            }
        }

        private void mnuLine_Click(object sender, RoutedEventArgs e)
        {
            if (mnuLine.IsChecked)
                lstLine.Visibility = Visibility.Visible;
            else
                lstLine.Visibility = Visibility.Hidden;
        }
        private void mnuOption_Click(object sender, RoutedEventArgs e)
        {
            mnuLine.Visibility = Visibility.Visible;
            mnuWrap.Visibility = Visibility.Visible;
            mnuHighlight.Visibility = Visibility.Visible;
            
        }

        private void mnuAccess_Click(object sender, RoutedEventArgs e)
        {
            mnuAdd.Visibility = Visibility.Visible;
            mnuDelete.Visibility = Visibility.Visible;
            mnuEdit.Visibility = Visibility.Visible;
        }
       
        private void mnuPlot_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void mnuAdd_Click(object sender, RoutedEventArgs e)
        {
            AddUser user = new AddUser();
            user.setUserList(swarmUserList);
            user.ShowDialog();
        }
        private void mnuEdit_Click(object sender, RoutedEventArgs e)
        {
            EditPermissions editPerm = new EditPermissions();
            editPerm.ShowDialog();
        }
        private void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteUser delUser = new DeleteUser();
            delUser.ShowDialog();
        }

        public void setUserList(List<string> list)
        {
            swarmUserList = list;
        }

        public void setProgUserList(List<string> list)
        {
            progUserList = list;
        }
        struct tags
        {
            public int start;
            public int size;
        };
        List<tags> m_tags = new List<tags>();
        List<String> keywords = new List<String>();
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (et == editorType.collaborator)
            {
                for (int i = 0; i < progUserList.Count; i++)
                {
                    lstUsers.Items.Add(progUserList[i]);
                }
            }
            keywords.Add("int");
            keywords.Add("double");
            keywords.Add("for");
        }

        private void format()
        {
            m_tags.Sort(compare);
            for (int i = 0; i < m_tags.Count; i++)
            {
                TextPointer str = rtbInput.Document.ContentStart.GetPositionAtOffset(m_tags[i].start, LogicalDirection.Forward);
                TextPointer stp = str.GetPositionAtOffset(m_tags[i].size, LogicalDirection.Backward);
                TextRange ts = new TextRange(str, stp);
                ts.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Blue));
            }
        }
        private void syntax()
        {
            TextPointer start = rtbInput.Document.ContentStart;
            TextPointer end = rtbInput.Document.ContentEnd;
            TextRange tr = new TextRange(start, end);
            tr.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Black)); 
            m_tags.Clear();
            for (int s = 0; s < keywords.Count && tr.Text.Length > 2; s++)
            {
                int index = -1;
                string text = tr.Text.ToString();
                string[] txt;
                index = text.LastIndexOf(keywords[s]);
                while (index != -1 && text.Length > 0)
                {
                    tags t = new tags();
                    text = text.Substring(0, index + keywords[s].Length);
                    txt = text.Split('\n');
                    int num = 0;
                    for (int i = 0; i <txt.Length; i++)
                        if (txt[i].Length > 1)
                            num = num + 1;
                    if ((index == 0 || (index > 0 && (text[index - 1] == ' ' || text[index - 1] == '\n'))) && index + keywords[s].Length <= tr.Text.Length && (tr.Text[index + keywords[s].Length] == ' ' || tr.Text[index + keywords[s].Length] == '\r'))
                    {
                        t.start = index+2*num;
                        t.size = keywords[s].Length;
                        m_tags.Add(t);
                    }
                    text = text.Substring(0, index);
                    index = text.LastIndexOf(keywords[s]);
                }
            }
            format();
        }

        
        private void LineNumbers()
        {
            TextPointer start = rtbInput.Document.ContentStart;
            TextPointer end = rtbInput.Document.ContentEnd;
            TextRange tr = new TextRange(start, end);
            string[] txt = tr.Text.Split('\n');

            if (tr.Text.Length > 2)
            {
                if (!mnuWrap.IsChecked)
                {
                    lstLine.Items.Clear();
                    if (txt.Length > 0 && lstLine.Items.Count >= 0)
                    {
                        if (lstLine.Items.Count <= txt.Length - 2)
                        {
                            while (lstLine.Items.Count <= txt.Length - 2)
                                lstLine.Items.Add(lstLine.Items.Count + 1);
                        }
                    }
                }
                else
                {
                    if (txt.Length > 0 && lstLine.Items.Count >= 0)
                    {
                        int lines = 0;
                        lstLine.Items.Clear();
                        int i;
                        
                        for (i = 0; i <= txt.Length - 2; i++)
                        {
                            
                            lines = 0;
                            lines += txt[i].Length / 99;
                            if (txt[i].Length % 99 != 0)
                                lines += 1;
                                lstLine.Items.Add(i + 1);
                            for (int j = 1; j< lines; j++)
                            {
                                lstLine.Items.Add(" ");
                            }
                        }
                       
                    }
                }
            }
            tr = new TextRange(rtbInput.Document.ContentStart, rtbInput.Document.ContentEnd);
            
            if (tr.Text.Length == 0 && lstLine.Items.Count > 0)
            {
                while (lstLine.Items.Count > 0)
                    lstLine.Items.RemoveAt(lstLine.Items.Count - 1);
            }
            }

             
            private int compare(tags t1, tags t2)
            {
                if (t1.start < t2.start)
                    return 1;
                if (t1.start == t2.start)
                    return 0;
                return -1;
            }


            private void rtbInput_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
            {
                LineNumbers();
                syntax();
            }
            private void ShowError(string Msg)
            {
                System.Windows.MessageBox.Show(Msg, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            private void btnCompute_Click(object sender, RoutedEventArgs e)
            {
                
            }

            public void loadProgram(int read, int write, string text)
            {
                TextPointer tp = rtbInput.CaretPosition.GetPositionAtOffset(0, LogicalDirection.Forward);
                rtbInput.CaretPosition.InsertTextInRun(text);
                //rtbChat.CaretPosition.InsertParagraphBreak();
                rtbInput.CaretPosition = tp;
            }

            private void mnuSave_Click(object sender, RoutedEventArgs e)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "ssf files (*.ssf)|*.ssf|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName,false);
                            using (sw)
                            {

                                TextPointer start = rtbInput.Document.ContentStart;
                                TextPointer end = rtbInput.Document.ContentEnd;
                                TextRange tr = new TextRange(start, end);
                                sw.Write(tr.Text.ToString());
                                sw.Close();
                            } 
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show("Error: Could not Write file to disk. Original error: " + ex.Message);
                    }
                }

            }
    }
}
