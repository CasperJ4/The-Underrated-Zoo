using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController cha;
    Vector3 moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        cha = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        cha.Move(moveSpeed * 100 * Time.deltaTime);
    }
}
