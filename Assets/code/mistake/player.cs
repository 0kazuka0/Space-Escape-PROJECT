using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D p;
    private Vector2 movevelocity;
    private void Start()
    {
        p = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movevelocity = (new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))).normalized * speed;
    }
    private void FixedUpdate()
    {
        p.MovePosition(p.position + movevelocity * Time.deltaTime);
    }
}
