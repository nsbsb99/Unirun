using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //�������⼭ �� �� �ֵ��� static�� �ٿ���.
    public static GameManager instance;

    public bool isGameOver = false;
    public TMP_Text scoreText;
    public GameObject gameoverUI;

    public Transform myPlayer;

    private int score = 0;

    //������Ʈ�� �����ϴ��� ���θ� üũ�ϴ� �Լ�
    //public static bool IsValid<T>(this T target) where T : Component
    //{
    //   if(target == null || target == default) { return false; }
    //   else { return true; }
    //}

    //����Ʈ�� ��ȿ���� ���θ� üũ�ϴ� �Լ�
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
            Debug.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ�!");
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
        //���� ����
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
