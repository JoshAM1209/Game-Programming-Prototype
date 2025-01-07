using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletLife = 1f;
    public float rotation = 0f;
    public float speed = 1f;

    private Vector2 spawnPoint;
    private float timer = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector2(transform.position)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
