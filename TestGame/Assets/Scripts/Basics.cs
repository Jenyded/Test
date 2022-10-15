using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class Basics : MonoBehaviour
{
    public GameObject[] objs = new GameObject[3];

    public Transform target;

    public BoxCollider box;

    public Light _light;

    public float speed = 5.0f; public float rotateSpeed = 10f;

    public Transform[] transforms = new Transform[3];
    

    private void Start()
    {


      //  for (int i = 0: i < objs.Lenght; i++)
       //     obj[i].SetActive(false)
    }

    private void Update()
    {
        for(int i = 0; i < transforms.Length; i++)
        {
            if (transforms[i] == null)
                continue;
            
            transforms[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            transforms[i].Rotate(new Vector3(-1, 0, 0) * rotateSpeed * Time.deltaTime);

            float posX = transforms[i].position.x;
            if (posX < -10f && transforms[i].gameObject.name == "Cube")
                Destroy(transforms[i].gameObject);
        }
    }
}
