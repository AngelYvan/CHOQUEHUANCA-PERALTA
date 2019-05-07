using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExecute : MonoBehaviour
{
    /*private GameObject currentButton;
    private clicker = new Clicker();*/
    void Update()
    {
        /*Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation *
        Vector3.forward);
        RaycastHit hit;
        GameObject hitButton = null;
        PointerEventData data = new PointerEventData
        (EventSystem.current);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "Button")
            {
                hitButton = hit.transform.parent.gameObject;
            }
        }
        if (currentButton != hitButton)
        {
            if (currentButton != null)
            { // unhighlight
                ExecuteEvents.Execute<IPointerExitHandler>(currentButton,
                data, ExecuteEvents.pointerExitHandler);
            }
            currentButton = hitButton;
            if (currentButton != null)
            { // highlight
                ExecuteEvents.Execute<IPointerEnterHandler>
                (currentButton, data,
                ExecuteEvents.pointerEnterHandler);
            }
        }
        if (currentButton != null)
        {
            if (clicker.clicked())
            {
                ExecuteEvents.Execute<IPointerClickHandler>
                (currentButton, data, ExecuteEvents.pointerClickHandler);
            }
        }*/
    }
}
