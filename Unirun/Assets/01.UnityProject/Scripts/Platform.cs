using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject[] coins;
    //private bool stepped = false;

    private void OnEnable()
    {
        //stepped = false;

        //���� Ȱ��ȭ 
        for(int i = 0; i < obstacles.Length; i++)
        {
            if(Random.Range(0,3) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }

        //���� Ȱ��ȭ
        for(int j = 0; j < coins.Length;j++)
        {
            if (Random.Range(0, 4) == 0)
            {
                coins[j].SetActive(true);
            }
            else
            {
                coins[j].SetActive(false);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
