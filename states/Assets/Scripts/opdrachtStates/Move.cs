using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Transform ts;

    protected void TSset(Transform _ts)
    {
        ts = _ts;
    }

    protected void MovePos(float x, float y)
    {
        ts.position += new Vector3(x, y, 0) * Time.deltaTime * 5;
    }
}
