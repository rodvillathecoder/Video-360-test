using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    //[SerializeField] Image _buttonImage;
   // [SerializeField] Image _fillAmount;


    // Start is called before the first frame update
    void Start()
    {
       // _fillAmount = 0;
    }






   

    public void OnPointerExit()
    {
       // throw new NotImplementedException();
    }

    public void OnPointerEnter()
    {
        //throw new NotImplementedException();
    }

    public bool OnPointerStay()
    {
        //throw new NotImplementedException();
        return false;
    }

    public virtual void OnPointerClick()
    {
       // throw new NotImplementedException();

    }


}
