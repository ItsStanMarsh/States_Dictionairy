using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Move
{

    float inputX;
    float inputY;

    void Start()
    {
        TSset(GetComponent<Transform>());
    }

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        MovePos(inputX, inputY);
    }
}
