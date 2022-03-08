using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instance; //  �̱����� �Ҵ��� ��������
    public bool isGameover = false; // ���ӿ��� ����
    public Text scoreText; //������ ����� UI�ؽ�Ʈ
    public GameObject gameoverUI; // ���ӿ����� Ȱ��ȭ�� UI ���� ������Ʈ

    private int score = 0; //��������


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            //instance�� ����ִٸ� (null) �װ��� �ڱ� �ڽ��� �Ҵ�
            instance = this;
        }
        else
        {
            //instance �� �̹� �ٸ� GameManager ������Ʈ�� �Ҵ�Ǿ� �ִ°��

            //���� �� �� �̻��� GameManager ������Ʈ�� �����Ѵٴ� �ǹ�
            //�̱��� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ� �ڽ��� ���� ������Ʈ�� �ı�
            Debug.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ�!");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {//���ӿ��� ���¿��� ������ ������� �� �ְ� �ϴ� ó��
        if (isGameover && Input.GetMouseButton(0))
        {
            //���ӿ��� ���¿��� ���콺 ���� ��ư�� Ŭ���ϸ� ���� �� �����
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    //������ ������Ű�� �޼���
    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            //������ ����
            score += newScore;
            scoreText.text = "Score :" + score;
        }
    }
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
}
