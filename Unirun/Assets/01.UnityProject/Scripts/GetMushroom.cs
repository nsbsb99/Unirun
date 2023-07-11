using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMushroom : MonoBehaviour
{
    public Transform myPlayer;
    private SpriteRenderer mushroomRender;

    //¹ö¼¸ È¹µæ ÈÄ °æ°úÇÑ ½Ã°£
    public float waitTime;

    //¹ö¼¸ È¹µæ ¿©ºÎ
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
        //¹ö¼¸ È¿°ú ³¡³»±â
        waitTime += Time.deltaTime;

        if (waitTime >= 2 && alreadyGet == true)
        {
            myPlayer = FindObjectOfType<PlayerController>().transform;
            myPlayer.localScale /= 1.5f;

            alreadyGet = false;
        }
    }
}
