using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForStarExample : MonoBehaviour
{
    public int height = 5; // 피라미드 높이 (Unity Editor에서 설정 가능)
    public int starcount = 5;
    public GameObject cube;
    public GameObject Sphere;

    void Start()
    {
        //PrintPyramid1(height);
        //PrintPrefabPyramid1(height);
        //PrintPyramid2(height);
        //PrintPrefabPyramid2_2(height);
        PrintPyramid3(height);
        PrintPrefabPyramid3_1(height);
    }

    // Instantiate(cube, new Vector3(j, -i, 0), Quaternion.identity);
    
    //  *
    //  **
    //  *** 형태의 피라미드
    void PrintPyramid1(int height)
    {
        string pyramid = ""; // 결과를 저장할 문자열

        for (int i = 0; i < height; i++) // 피라미드의 높이
        {
            for (int j = 0; j <= i; j++) // 현재 줄의 별 개수
            {
                pyramid += "*";
            }
            pyramid += "\n"; // 한 줄 끝나면 줄 바꿈
        }

        Debug.Log(pyramid); // Unity 콘솔에 출력
    }


    
    void PrintPrefabPyramid1(int height)
    {
        for (int i = 0; i < height; i++) // 피라미드의 높이
        {
            for (int j = 0; j <= i; j++) // 현재 줄의 큐브 개수
            {
                // 큐브를 해당 위치에 생성
                Instantiate(cube, new Vector3(j, -i, 0), Quaternion.identity);
            }
        }
    }

    //  ***
    //  **
    //  * 형태의 피라미드
    
    void PrintPyramid2(int height)
    {
        string pyramid = "";

        for (int i = 0; i < height; i++) // 피라미드의 높이
        {
            for (int j = starcount; j > i; j--) // 현재 줄의 별 개수
            {
                pyramid += "*";
            }
            pyramid += "\n"; // 한 줄 끝나면 줄 바꿈
        }
        Debug.Log(pyramid); // Unity 콘솔에 출력
    }

    void PrintPrefabPyramid2_2(int height)
    {
        for (int i = 0; i < height; i++) // 피라미드의 높이
        {
            for (int j = starcount; j > i; j--) // 현재 줄의 큐브 개수
            {
                // 큐브를 해당 위치에 생성
                Instantiate(cube, new Vector3(-j, -i, 0), Quaternion.identity);
            }
        }
    }

   //    *
   //   **
   //  *** 형태의 피라미드
   
    void PrintPyramid3(int height)
    {
        string pyramid = "";
        

        for (int i = 0; i < height; i++) // 피라미드의 높이
        {
            for (int j = starcount; j > i; j--) // 현재 줄의 별 개수
            {
                pyramid += "  ";
            }

            for (int z = 0; z <= i; z++) // 현재 줄의 별 개수
            {
                pyramid += "*";
            }
            pyramid += "\n"; // 한 줄 끝나면 줄 바꿈
        }
        Debug.Log(pyramid);
    }

    void PrintPrefabPyramid3_1(int height)
    {
        for (int i = 0; i < height; i++) // 피라미드의 높이
        {
            for (int j = starcount; j > i; j--) // 현재 줄의 공 개수
            {
                Instantiate(Sphere, new Vector3(-j, -i, 0), Quaternion.identity);
            }

            for (int z = 0; z <= i; z++) // 현재 줄의 큐브 개수
            {
                Instantiate(cube, new Vector3(-z, -i, 0), Quaternion.identity);
            }
            
        }
        
    } 
}

    
    // *****
    //  ***
    //   *
    //   *
    //  ***
    // ***** 형태의 피라미드
    
   



