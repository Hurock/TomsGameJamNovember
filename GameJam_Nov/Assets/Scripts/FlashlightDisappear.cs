using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightDisappear : MonoBehaviour
{
    bool isSeeingMonster;
    float timer;

    private void Update()
    {
        if (isSeeingMonster)
        {
            timer += Time.deltaTime;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            isSeeingMonster = true;
            if (timer > 1f)
            {
                collision.gameObject.GetComponent<Monster>().Disappear();
                isSeeingMonster = false;
                timer = 0f;
            }
        }
    }
}
