using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyperlink : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenLink(string link){
        Application.OpenURL(link);
    }
}
