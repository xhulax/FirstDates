using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToothBrushScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler
{
    private Vector3 offSet;
    private Camera mainCamera;

    private Rigidbody2D thisRB;


    void Start()
    {
        mainCamera = Camera.main;
        thisRB = GetComponent<Rigidbody2D>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 mouseWorldPos = GetWorldPos(eventData);
        offSet = transform.position - mouseWorldPos;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mouseWorldPos = GetWorldPos(eventData);
        transform.position = mouseWorldPos + offSet;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    private Vector3 GetWorldPos(PointerEventData eventData)
    {
        Vector3 screenPosition = eventData.position;
        screenPosition.z = Mathf.Abs(mainCamera.transform.position.z - transform.position.z); // Set the correct z depth
        return mainCamera.ScreenToWorldPoint(screenPosition);
    }


}
