//q: Using Unity, how do I move a character in a direction?
//a: Use the transform.Translate() method.
//q: Can you show me how?
//a: Sure, here's a script that moves a character in the direction of the arrow keys.

using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

    public float speed = 10.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
