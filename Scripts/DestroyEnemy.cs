using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
 private void OnCollisionEnter(Collision collision)
 {
    // whwn enemy collide with player it destroy but when spawn enemies collide it does not  destroy i failed to make logic of spawn enemies destroy
    if(collision.collider.CompareTag("Enemy"))
    {
        Destroy(collision.gameObject);
        Debug.Log("Score is 25");
    }
   
 }
}
