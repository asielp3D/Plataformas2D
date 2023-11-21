using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarCounter : MonoBehaviour
{
   public static StarCounter instance;

   public TMP_Text starsText;
   public int currentStars = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        starsText.text = "-  x" + currentStars.ToString();
    }
    
    void Awake()
    {
        instance = this;
    }
    
    
    public void IncreaseStars(int v)
    {
        currentStars += v;
        starsText.text = "-  x" + currentStars.ToString();
    }
}
