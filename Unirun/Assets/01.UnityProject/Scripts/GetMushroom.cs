using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMushroom : MonoBehaviour
{
    public Transform myPlayer;
    private SpriteRenderer mushroomRender;

    //���� ȹ�� �� ����� �ð�
    public float waitTime;

    //���� ȹ�� ����
    private bool alreadyGet = false;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") && alreadyGet == false)
        {
            waitTime = 0;
            mushroomRender = this.GetComponent<SpriteRenderer>();
            mushroomRender.enabled = false;

            myPlayer = FindObjectOfType<PlayerController>().transform;
            myPlayer.localScale *= 1.5f;

            alreadyGet = true;
        }
    }

    private void Update()
    {
        //���� ȿ�� ������
        waitTime += Time.deltaTime;

        if (waitTime >= 2 && alreadyGet == true)
        {
            myPlayer = FindObjectOfType<PlayerController>().transform;
            myPlayer.localScale /= 1.5f;

            alreadyGet = false;
        }
    }
}
