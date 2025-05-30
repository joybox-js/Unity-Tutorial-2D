using UnityEngine;

public class PinballManager : MonoBehaviour
{
    public Rigidbody2D leftBarRb;
    public Rigidbody2D rightBarRb;
    public float totalScore = 0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftBarRb.AddTorque(35f);
        }
        else
        {
            leftBarRb.AddTorque(-25f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightBarRb.AddTorque(-35f);
        }
        else
        {
            rightBarRb.AddTorque(25f);
        }
    }
}
