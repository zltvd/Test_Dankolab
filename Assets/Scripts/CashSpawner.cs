using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashSpawner : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform target;
    private Transform _transform;
    private float _power = 45f;
    void Start()
    {
        _transform = transform;
        target.transform.position = new Vector2(Random.Range(70f, 1000f), 1550);
        Debug.Log(target.transform.position);
        Vector2 Power = target.position - _transform.position;
        Power = Power.normalized * _power;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Power, ForceMode2D.Impulse);
       
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
