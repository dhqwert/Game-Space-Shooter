using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;
    void Update()
    {
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
        
        // var newPosition = transform.position;
        // newPosition.y += Time.deltaTime * flySpeed;
        // transform.position = newPosition;
    }
}