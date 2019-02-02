using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private object currentPopUpMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPopUPMenu(GameObject menu) {
        menu.gameObject.SetActive(true);
        currentPopUpMenu = menu.GetComponent<Menu>();
        //currentPopUpMenu.IsOpen = true;
    }
}
