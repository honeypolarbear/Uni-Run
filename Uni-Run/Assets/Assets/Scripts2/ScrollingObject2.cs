using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject2 : MonoBehaviour
{
    public float speed = 10f;// �̵��ӵ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager2.instance.isGameover)
        {

            // �ʴ� speed�� �ӵ��� �������� �����̵�
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        } 
    }
}
