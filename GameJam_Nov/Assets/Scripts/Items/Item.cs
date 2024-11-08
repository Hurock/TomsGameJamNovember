using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
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
    float itemValue;

    public ObjectType itemType;

    public GameObject interactionText;

    bool isInteracting;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        interactionText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            isInteracting = true;
        }
        else if (Input.GetButtonUp("Interact"))
        {
            isInteracting = false;
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isInteracting)
        {
            GameObject player = collision.gameObject;
            CollectItem(player);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactionText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactionText.SetActive(false);
        }
    }


    void CollectItem(GameObject player)
    {
        switch(itemType)
        {
            case ObjectType.Battery:
                print("Battery collected");
                player.GetComponent<PlayerResources>().AddBattery(itemValue);
                break;

            case ObjectType.Food:
                print("Food collected");
                player.GetComponent<PlayerResources>().AddFood(itemValue);
                break;

            case ObjectType.Water:
                print("Water collected");
                player.GetComponent<PlayerResources>().AddWater(itemValue);
                break;
            
        }
    }
}
