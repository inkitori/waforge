using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class Map : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 originalScale = new Vector3(1, 4, 1);
    [SerializeField] GameObject map;
    public void RenderMap()
    {
        map.SetActive(true);
    }

    public void CloseMap()
    {
        map.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseMap();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("enter");
        transform.localScale = originalScale * 1.1f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("exit");
        transform.localScale = originalScale;
    }
}
