using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float returnPosX = 15f;
    public float randomPosY;
    
    public Vector3 returnPos;
    
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        
        if (transform.position.x <= -returnPos.x)
        {
            randomPosY = Random.Range(-8f, -2.5f);
            
            // transform.position = new Vector3(returnPosX, randomPosY, 0);
            
            transform.position = new Vector3(returnPos.x, randomPosY, 0);
        }
    }
}