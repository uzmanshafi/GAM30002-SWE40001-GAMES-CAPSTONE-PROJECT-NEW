using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    [SerializeField] public float speed;

    public Vector2 position;
    public Vector2 direction;

    //public Vector2 Position => position;
    //public Vector2 Direction => direction;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public abstract void move();

}
