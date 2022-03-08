using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject2 : MonoBehaviour
{
    public float speed = 10f;// 이동속도
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager2.instance.isGameover)
        {

            // 초당 speed의 속도로 왼쪽으로 평행이동
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        } 
    }
}
