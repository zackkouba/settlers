using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemy : MonoBehaviour
{
    public float speed = 5f;
 

    [SerializeField] private Transform target;


    

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position;
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }


}
