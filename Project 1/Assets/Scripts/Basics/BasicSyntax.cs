using UnityEngine;

// code from unity learn tutorials, conventions and syntax
public class BasicSyntax : MonoBehaviour
{
    void Start()
    {
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm About to hit the ground!");
        }
    }
    /* apparently there can be multi line comments
     * sick
     */
}
