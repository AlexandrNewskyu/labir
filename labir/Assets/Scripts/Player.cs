using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Text textCountpaper;
    [SerializeField] Text textTakePaper;
    [SerializeField] int Countpaper;
    // Start is called before the first frame update
    void Start()
    {
        Countpaper = GameObject.FindGameObjectsWithTag("Paper").Length;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();  
    }

    void UpdateText()
    {
        textCountpaper.text = $"Papers : {Countpaper}";

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Paper"))
        {
            textTakePaper.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                textTakePaper.gameObject.SetActive(false);
                Destroy(other.gameObject);
                Countpaper--;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        textTakePaper.gameObject.SetActive(false);   
    }
}
