using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToTarget : MonoBehaviour
{
    public float rotationSpeed;
    private Vector2 direction;

    public GameObject target;

    
     public Collider2D EnemyStartbox;

   public bool chase = false;
    public float moveSpeed;


    void Update()
    {
        
        if (chase == true) { 
        direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);


        //Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime); }
    }


    private void OnTriggerEnter2D(Collider2D Col)
    {
        Debug.Log("fartin");
    }
}
