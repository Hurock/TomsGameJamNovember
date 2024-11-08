using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public float deadTimer;

    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > deadTimer)
        {
            //kill player
        }
    }

    public void Disappear()
    {
        Destroy(gameObject);
        print("monster destroyed");
    }
}
