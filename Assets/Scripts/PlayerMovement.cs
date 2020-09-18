using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        verticalInput = Input.GetAxis("Horizontal");
        Vector3 position = this.transform.position;
        position.x = position.x + (this.MovementSpeed * verticalInput * Time.deltaTime);
        this.transform.position = position;
    }
}
