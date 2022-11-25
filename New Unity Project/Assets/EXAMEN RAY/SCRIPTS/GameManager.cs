using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    // .setEaseInOutQuint().setOnComplete(Latido);
    [SerializeField]
    GameObject cameraView, mainMenu, cameraTip, creationMenu;

    [SerializeField]
    GameObject tree, silo, tree2, farmland;
    
    [SerializeField]
    Menus menuStatus = Menus.isMainMenu;
    bool inMainMenu = true;
    public Vector3 pCameraModificada;
    public enum Menus
    {
        isMainMenu,
        isCamera,
        isCreation,
        pine,
        silos,
        pine2,
        farmlands,
    }



    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        switch (menuStatus)
        {
            case Menus.isMainMenu:
                menuStatus = Menus.isMainMenu;
                break;
            case Menus.isCamera:
                menuStatus = Menus.isCamera;
                break;
            case Menus.isCreation:
                menuStatus = Menus.isCreation;
                CreationBack();
                break;
            case Menus.pine:
                menuStatus = Menus.pine;
                CreateTree();
                break;
            case Menus.pine2:
                menuStatus = Menus.pine2;
                CreateTree2();
                break;
            case Menus.silos:
                menuStatus = Menus.silos;
                CreateSilo();
                break;
            case Menus.farmlands:
                menuStatus = Menus.farmlands;
                CreateFarmland();
                break;
        }

        if (menuStatus == Menus.isCamera)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("click");
                pCameraModificada = pCameraModificada + cameraView.transform.position;
                transform.position = pCameraModificada.x * Input.mousePosition;
                transform.position = pCameraModificada.z * Input.mousePosition;
            }
        }
    }

    public void ClickOnCamera()
    {
        if (menuStatus == Menus.isMainMenu)
        {
            mainMenu.SetActive(false);
            cameraTip.SetActive(true);
            menuStatus = Menus.isCamera;
            Debug.Log("oi");
        }
    }

    public void ClickOnCreate()
    {
        if (menuStatus == Menus.isMainMenu)
        {
            mainMenu.SetActive(false);
            creationMenu.SetActive(true);
            menuStatus = Menus.isCreation;
            Debug.Log("oi");
        }
    }

    public void ClickOnTree()
    {
        menuStatus = Menus.pine;
    }
    public void ClickOnTree2()
    {
        menuStatus = Menus.pine2;
    }
    public void ClickOnSilos()
    {
        menuStatus = Menus.silos;
    }
    public void ClickOnFarmland()
    {
        menuStatus = Menus.farmlands;
    }


    void CreateTree()
    {
       if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject)
                {
                    Instantiate(tree, (hitInfo.point + Vector3.up * tree.transform.localScale.y / 2), Quaternion.identity);
                    menuStatus = Menus.isCreation;

                }
            }
        }
    }
    void CreateTree2()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject)
                {
                    Instantiate(tree2, (hitInfo.point + Vector3.up * tree.transform.localScale.y / 2), Quaternion.identity);
                    menuStatus = Menus.isCreation;

                }
            }
        }
    }
    void CreateSilo()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject)
                {
                    Instantiate(silo, (hitInfo.point + Vector3.up * tree.transform.localScale.y / 2), Quaternion.identity);
                    menuStatus = Menus.isCreation;

                }
            }
        }
    }
    void CreateFarmland()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject)
                {
                    Instantiate(farmland, (hitInfo.point + Vector3.up * tree.transform.localScale.y / 2), Quaternion.identity);
                    menuStatus = Menus.isCreation;

                }
            }
        }
    }
    void CreationBack()
    {
        

    }
    
    public void ClickOnBack()
    {
        mainMenu.SetActive(true);
        creationMenu.SetActive(false);
        menuStatus = Menus.isMainMenu;
    }
}