using UnityEngine;
 
public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
     
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normalDir = dir.normalized;
         
        transform.position += moveSpeed * Time.deltaTime * normalDir;

        transform.LookAt(transform.position + normalDir);
    }
}