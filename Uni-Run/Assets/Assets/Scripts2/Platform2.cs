using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
    public GameObject[] obstacles;// ��ֹ� ������Ʈ��
    private bool stepped = false;//�÷��̾� ĳ���Ͱ� ��Ҵ°�
    // Start is called before the first frame update
    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        //�÷��̾� ĳ���Ͱ� �ڽ��� ������� ������ �߰��ϴ� �ڸ�
    }
}
