using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMushroom : MonoBehaviour
{
    public Transform myPlayer;
    private float timeBigger;
    private float finishBigger = 10f;

    private void Start()
    {
        timeBigger = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);

            myPlayer = GameObject.FindObjectOfType<PlayerController>().transform;
            //Debug.LogFormat("캐릭터의 크기: {0}",myPlayer.localScale);

            myPlayer.localScale *= 1.5f;


        }
    }
}
