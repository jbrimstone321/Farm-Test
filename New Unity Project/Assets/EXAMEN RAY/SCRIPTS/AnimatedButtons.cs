using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedButtons : MonoBehaviour
{
  
    public void ScaleUp()
    {

        LeanTween.scale(gameObject, Vector3.one * 1.2f, 0.5f).setEaseInBounce();

    }

    public void ScaleDown()
    {

        LeanTween.scale(gameObject, Vector3.one, 0.2f);


    }
}
