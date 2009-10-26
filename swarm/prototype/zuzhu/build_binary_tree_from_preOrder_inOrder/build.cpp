#include <iostream>
#include <vector>

#define TREELEN 6

using namespace std;

struct NODE
{
    NODE* pLeft;
    NODE* pRight;
    char chValue;
};

void PreOrder(NODE* pRoot)
{
    if (pRoot != NULL)
    {
        cout << pRoot->chValue << " ";
        PreOrder(pRoot->pLeft);
        PreOrder(pRoot->pRight);
    }
}

void InOrder(NODE* pRoot)
{
    if (pRoot != NULL)
    {
        InOrder(pRoot->pLeft);
        cout << pRoot->chValue << " ";
        InOrder(pRoot->pRight);
    }
}

void PostOrder(NODE* pRoot)
{
    if (pRoot != NULL)
    {
        PostOrder(pRoot->pLeft);
        PostOrder(pRoot->pRight);
        cout << pRoot->chValue << " ";
    }
}

void Level(NODE* root)
{
    if (root == NULL)
        return;
    vector<NODE*> vec;
    vec.push_back(root);
    int cur = 0;
    int last = 1;

    while (cur < vec.size())
    {
        last = vec.size();
        while (cur < last)
        {
            cout << vec[cur]->chValue << " ";
            if (vec[cur]->pLeft)
                vec.push_back(vec[cur]->pLeft);
            if (vec[cur]->pRight)
                vec.push_back(vec[cur]->pRight);
            ++cur;
        }
        cout << endl;
    }
}

void ReBuild(char* pPreOrder, char* pInOrder, int nTreeLen, NODE** pRoot)
{
    if (pPreOrder == NULL || pInOrder == NULL)
    {
        return;
    }

    NODE* pTemp = new NODE;
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

int main(int argc, char *argv[])
{
    char szPreOrder[TREELEN] = {'a', 'b', 'd', 'c', 'e', 'f'};
    char szInOrder[TREELEN] = {'d', 'b', 'a', 'e', 'c', 'f'};

    NODE* pRoot = NULL;
    ReBuild(szPreOrder, szInOrder, TREELEN, &pRoot);
    cout << "PreOrder: " << endl;
    PreOrder(pRoot);
    cout << endl;
    cout << "InOrder: " << endl;
    InOrder(pRoot);
    cout << endl;
    cout << "PostOrder: " << endl;
    PostOrder(pRoot);
    cout << endl;
    cout << "LevelTraverse: " << endl;
    Level(pRoot);
    cout << endl;
}