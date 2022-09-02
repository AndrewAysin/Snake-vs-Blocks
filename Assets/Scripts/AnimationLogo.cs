using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationLogo : MonoBehaviour
{
    public Animation animationLogo;
    public void Awake()
    {
        animationLogo.PlayQueued("Logo");
    }
}
