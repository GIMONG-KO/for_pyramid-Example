using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;




public class for_Example : MonoBehaviour
{
    void Start()
    {
        // for : 특정 횟수만큼  반복하고 싶을떄 사용
        // for(초기화 식 ; 조건식 ; 증강식){}
        for (int i = 0; i < 4; i++)
        {
            Debug.Log($"현재 i의 값: {i}");
        }
        
        // while : 조건이 true 인 동안 계속반복
        // while(조건식)
        int k = 0;
        while (k < 4)
        {
            Debug.Log($"현재 k의 값: {k}");
            k++;
        }
        
        // do-while : 조건검사 전에 먼조 코드를 한번 실행하고 반복
        // do{} while(조건식);
        int z = 3;
        do
        {
            Debug.Log($"현재 z의 값: {z}");
            z--;
        } while (z > 0);
        
        // foreach : 컬렉션(배열, 리스트 등)의 모든 요소를 순차적으로 접근할 때 사용
        // foreach(var 변수 in 컬렉션){}
        int[] kokomong = { 0, 1, 2, 3, 4 };
        var danto = kokomong.Where(x => x % 3 == 1);
        foreach (var gimong in danto)
        {
            Debug.Log($"현재  k의 값: {gimong}");
        }
        
        // 이중 반복문
        for (int a = 0; a <= 5; a++) // 외부 반복문: 5번 실행
        {
            for (int b = 0; b < 3; b++) // 내부 반복문: i번 반복
            {
                Debug.Log($"a 와 b의 값: {a}, {b}");
            }
            Console.WriteLine(); // 한 줄 끝날 때 줄바꿈
        }
    }
}
