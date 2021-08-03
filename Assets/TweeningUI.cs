using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TweeningUI : MonoBehaviour
{
    public Vector3 endScale,startScale;
    public float delayValue;
    public LeanTweenType easeOutType,easeInType;
    void OnEnable()
    {
        LeanTween.scale(gameObject, endScale, delayValue).setEase(easeOutType);
    }

    void OnDisable()
    {
        LeanTween.scale(gameObject, startScale, delayValue).setEase(easeInType);
    }
}
