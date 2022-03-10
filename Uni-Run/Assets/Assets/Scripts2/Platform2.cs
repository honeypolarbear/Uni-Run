using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
    public GameObject[] obstacles;// 장애물 오브젝트들
    private bool stepped = false;//플레이어 캐릭터가 밟았는가
    // Start is called before the first frame update
    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        //플레이어 캐릭터가 자신을 밟았을때 점수를 추가하는 자리
    }
}
