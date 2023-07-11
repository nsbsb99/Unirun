using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //여기저기서 쓸 수 있도록 static을 붙였다.
    public static GameManager instance;

    public bool isGameOver = false;
    public TMP_Text scoreText;
    public GameObject gameoverUI;

    public Transform myPlayer;

    private int score = 0;

    //컴포넌트가 존재하는지 여부를 체크하는 함수
    //public static bool IsValid<T>(this T target) where T : Component
    //{
    //   if(target == null || target == default) { return false; }
    //   else { return true; }
    //}

    //리스트가 유효한지 여부를 체크하는 함수
    //public static bool IsValid<T>(this List <T> target)
    //{
    //   bool isInvalid = (target == null || target == default);
    //   isInvalid = isInvalid || target.Count == 0;
    //
    //   if(isInvalid == true) { return false; }
    //   else { return true; }
    //}

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        else
        {
            Debug.LogWarning("씬에 두 개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //점프 로직
        if(isGameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("PlayScene");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddScore(int newScore)
    {
        if(isGameOver == false) 
        {
            score += newScore;
            scoreText.text = string.Format("Score: {0}", score);
        }
    }

    public void OnPlayerDead()
    {
        isGameOver = true;
        gameoverUI.SetActive(true);
    }
}
