using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace rebuild
{
    class Program
    {
        class NODE
        {
            NODE pLeft;
            NODE pRight;
            char chValue;

            public NODE()
            {
                chValue = (char)0;
            }
        };

        void PreOrder(NODE pRoot)
        {
            if (pRoot != NULL)
            {
                cout << pRoot.chValue << " ";
                PreOrder(pRoot->pLeft);
                PreOrder(pRoot->pRight);
            }
        }

        void InOrder(NODE pRoot)
        {
            if (pRoot != NULL)
            {
                InOrder(pRoot->pLeft);
                cout << pRoot->chValue << " ";
                InOrder(pRoot->pRight);
            }
        }

        void ReBuild(string pPreOrder, string pInOrder, int nTreeLen, NODE pRoot)
        {
            if (pPreOrder == NULL || pInOrder == NULL)
            {
                return;
            }

            NODE pTemp = new NODE;
            pTemp->chValue = *pPreOrder;
            pTemp->pLeft = NULL;
            pTemp->pRight = NULL;

            if (*pRoot == NULL)
            {
                *pRoot = pTemp;
            }

            if (nTreeLen == 1)
            {
                return;
            }

            char* pOrgInOrder = pInOrder;
            char* pLeftEnd = pInOrder;
            int nTempLen = 0;

            while (*pPreOrder != *pLeftEnd)
            {
                if (pPreOrder == NULL || pLeftEnd == NULL)
                {
                    return;
                }

                nTempLen++;

                if (nTempLen > nTreeLen)
                {
                    break;
                }
                pLeftEnd++;
            }

            int nLeftLen = 0;
            nLeftLen = (int)(pLeftEnd - pOrgInOrder);
            
            int nRightLen = 0;
            nRightLen = nTreeLen - nLeftLen - 1;

            if (nLeftLen > 0)
            {
                ReBuild(pPreOrder + 1, pInOrder, nLeftLen, &((*pRoot)->pLeft));
            }

            if (nRightLen > 0)
            {
                ReBuild(pPreOrder + nLeftLen + 1, pInOrder + nLeftLen + 1, nRightLen, &((*pRoot)->pRight));
            }
        }

        static void Main(string[] args)
        {
            string filename = args[1];
            string preOrder = new string("");
            string inOrder = new string("");
            using (StreamReader sr = new StreamReader(filename))
            {
                string s = sr.ReadLine();
                if (s[0] == 'P')
                    preOrder = s.Substring(1, s.Length - 1);
                if (s[0] == 'I')
                    inOrder = s.Substring(1, s.Length - 1);
                sr.Close();
            }

            NODE pRoot = NULL;
            ReBuild(preOrder, inOrder, preOrder.Length, &pRoot);
            PreOrder(pRoot);
            cout << endl;
            InOrder(pRoot);
        }
    }
}
