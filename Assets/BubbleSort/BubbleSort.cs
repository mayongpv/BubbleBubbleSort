using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    private int temp;

    //���� ����
    /*���� �����Ѵ�.
     * -> ����Ʈ ���
     ���ʺ��� ���� �ΰ��� ���Ѵ�.
     ū ���� ���������� ������. -> ���� ���� ������ ���� ũ�� ��ġ�� �ٲ۴�.
     �׷� ���� ū ���� �� ���������� ����.
     �ѹ����� ������ ���� �����ʿ� �ִ� ���� �����Ѵ�.
     ������ ���ڵ鵵 ���� ������� �ݺ��Ѵ�.
     ���� ���ڰ� 3, 2, 4 ��� ���� Ƚ�� : 1, 2 ���̴ϱ� ���� Ƚ�� �� (���� ���� -1) �̴�.
     ���� ���� -1 ��ŭ �ݺ��Ѵ�.
     �ϼ�!
     */
    public void Start()
    {
        //1. ���� �����Ѵ�. -> ����Ʈ �̿�

        List<int> bubblesort = new List<int>()
        { 3, 5, 10, -2, 24};

        //2. ���ʺ��� ���� �ΰ��� ���Ѵ�.
        //ū ���� ���������� ������. -> ���� ���� ������ ���� ũ�� ��ġ�� �ٲ۴�.
        //->

        //�ٲ۴�? ��, �����ʿ� �ִ� ���� ���ʿ� �ְ� ���ʿ� �ִ� ���� ���������� �ִ´�?


        //�ٸ� �ڵ�

        for (int i = 0; i < bubblesort.Count; i++)
        {
            for (int j = 0; j < bubblesort.Count; j++)
            {
                if (bubblesort[i] < bubblesort[j])
                {
                    temp = bubblesort[i];
                    bubblesort[i] = bubblesort[j];
                    bubblesort[j] = temp;
                }
            }
        

        }
        for (int )
    }
}








