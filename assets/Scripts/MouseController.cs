using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{
    public Ray ray;

    public LayerMask draggableMask;
    public GameObject selectedObject;
    public static bool isDragging;

   // ChangePlace changePlace;


    private void Start()
    {
        isDragging = false;
      //  changePlace = FindObjectOfType<ChangePlace>();
    }

    private void Update()
    {
      

        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, draggableMask);
            if (hit.collider != null)
            {
                selectedObject = hit.collider.gameObject;
                isDragging = true;
            }
        }
        if(isDragging && selectedObject != null)
        {
           // changePlace.PlaceChange();
            Vector3 pos = mousePos();
            selectedObject.transform.position = pos;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        Vector3 mousePos()
        {
            return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        }
    }
}

