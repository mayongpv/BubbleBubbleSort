using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
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
        if (bubblesort[0] > bubblesort[1])
        {
            //�ٲ۴�? ��, �����ʿ� �ִ� ���� ���ʿ� �ְ� ���ʿ� �ִ� ���� ���������� �ִ´�?
            System.Console.WriteLine(bubblesort[0] = bubblesort[1]);
            System.Console.WriteLine(bubblesort[1] = bubblesort[0]);
            Debug.Log(bubblesort[0] = bubblesort[1]);
            Debug.Log(bubblesort[1] = bubblesort[0]);

        }
    }



}




