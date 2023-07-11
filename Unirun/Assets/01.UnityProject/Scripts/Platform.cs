using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject[] coins;
    public GameObject[] mushrooms;

    //private bool stepped = false;

    private void OnEnable()
    {
        //stepped = false;

        //가시 활성화 
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

        //코인 활성화
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

        //버섯 활성화
        for (int k = 0; k < mushrooms.Length; k++)
        {
            if (Random.Range(0, 6) == 0)
            {
                mushrooms[k].SetActive(true);
            }
            else
            {
                mushrooms[k].SetActive(false);
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
