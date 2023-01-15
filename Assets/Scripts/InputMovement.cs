using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputMovement : MonoBehaviour, IDragHandler
{
    public Transform characterA;
    public Transform characterB;
    public static InputMovement instance;
    private void Awake() => instance = this;

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector3 posA = characterA.position;
        posA.x = Mathf.Clamp(posA.x + (eventData.delta.x / 100), -4, 0);
        characterA.position = posA;
        
        Vector3 posB = characterB.position;
        posB.x = Mathf.Clamp(posB.x - (eventData.delta.x / 100), 0, 4);
        characterB.position = posB;
        
    }
}