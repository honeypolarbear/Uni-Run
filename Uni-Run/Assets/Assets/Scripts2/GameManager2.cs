using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instance; //  싱글턴을 할당할 전역변수
    public bool isGameover = false; // 게임오버 상태
    public Text scoreText; //점수를 출력할 UI텍스트
    public GameObject gameoverUI; // 게임오버시 활성화할 UI 게임 오브젝트

    private int score = 0; //게임점수


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            //instance가 비어있다면 (null) 그곳에 자기 자신을 할당
            instance = this;
        }
        else
        {
            //instance 에 이미 다른 GameManager 오브젝트가 할당되어 있는경우

            //씬에 두 개 이상의 GameManager 오브젝트가 존재한다는 의미
            //싱글턴 오브젝트는 하나만 존재해야 하므로 자신의 게임 오브젝트를 파괴
            Debug.LogWarning("씬에 두 개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {//게임오버 상태에서 게임을 재시작할 수 있게 하는 처리
        if (isGameover && Input.GetMouseButton(0))
        {
            //게임오버 상태에서 마우스 왼쪽 버튼을 클릭하면 현재 씬 재시작
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    //점수를 증가시키는 메서드
    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            //점수를 증가
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
