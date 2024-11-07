using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D col;


    public enum ObjectType 
    {
        Battery,
        Food,
        Water
    }

    [SerializeField]
    float fillAmount;

    public ObjectType itemType;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //show text to grab item
            CollectItem();
            Destroy(gameObject);
        }
        
        
    }

    void CollectItem()
    {
        switch(itemType)
        {
            case ObjectType.Battery:
                print("Battery collected");
                break;

            case ObjectType.Food:
                print("Food collected");
                break;

            case ObjectType.Water:
                print("Water collected");
                break;
            
        }
    }
}
