using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLogic : MonoBehaviour
{
    public Builder builder;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            builder.Build(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
