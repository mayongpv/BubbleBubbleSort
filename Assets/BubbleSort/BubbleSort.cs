using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    //할일 적기
    /*수를 나열한다.
     * -> 리스트 사용
     왼쪽부터 수를 두개씩 비교한다.
     큰 수를 오른쪽으로 보낸다. -> 왼쪽 수가 오른쪽 보다 크면 위치를 바꾼다.
     그럼 가장 큰 수가 맨 오른쪽으로 간다.
     한바퀴가 끝나면 가장 오른쪽에 있는 수를 고정한다.
     나머지 숫자들도 같은 방법으로 반복한다.
     기존 숫자가 3, 2, 4 라면 실행 횟수 : 1, 2 번이니까 실행 횟수 는 (수의 개수 -1) 이다.
     수의 개수 -1 만큼 반복한다.
     완성!
     */
    public void Start()
    {
        //1. 수를 나열한다. -> 리스트 이용

        List<int> bubblesort = new List<int>()
        { 3, 5, 10, -2, 24};
        
        //2. 왼쪽부터 수를 두개씩 비교한다.
        //큰 수를 오른쪽으로 보낸다. -> 왼쪽 수가 오른쪽 보다 크면 위치를 바꾼다.
        if (bubblesort[0] > bubblesort[1])
        {
            //바꾼다? 즉, 오른쪽에 있는 수를 왼쪽에 넣고 왼쪽에 있는 수를 오른쪽으로 넣는다?
            System.Console.WriteLine(bubblesort[0] = bubblesort[1]);
            System.Console.WriteLine(bubblesort[1] = bubblesort[0]);
            Debug.Log(bubblesort[0] = bubblesort[1]);
            Debug.Log(bubblesort[1] = bubblesort[0]);

        }
    }



}




