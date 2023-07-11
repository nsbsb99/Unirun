using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    private bool getThis = false;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") && getThis == false)
        {
            getThis = true;
            GameManager.instance.AddScore(1);

            this.gameObject.SetActive(false);
        }
    }
}
