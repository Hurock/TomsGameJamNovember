using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Pool;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D col;

    [SerializeField]
    float playerSpeed;

    float playerRotation;

    Vector3 mousePos;
    Vector3 objectPos;

    int layer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = rb.GetComponent<Collider2D>();
        layer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveHorizontal * playerSpeed, moveVertical * playerSpeed);

        mousePos = Input.mousePosition;
        objectPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;
        playerRotation = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, playerRotation));

    }
}
