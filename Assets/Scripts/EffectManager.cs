using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectManager : MonoBehaviour
{
    public GameObject effectPoint;  //エフェクトの位置
    public Text name;       //現在のエフェクトの名前
    public Text detail;     //現在のエフェクトの詳細
    public Text page;       //ページ

    [Header("エフェクトのプレファブ")]
    public GameObject[] effectPrefabs;

    [Header("名前")]
    public string[] effectNames;

    [Header("詳細")]
    public string[] effectsDetails;

    private int currentPage;      //エフェクトの番号
    private GameObject currentEffect;  //現在のエフェクト

    // Start is called before the first frame update
    void Start()
    {
        currentPage = 0;
        currentEffect = Instantiate(effectPrefabs[0], effectPoint.transform);
        name.text = effectNames[currentPage];
        detail.text = effectsDetails[currentPage];
        page.text = "1 / " + effectPrefabs.Length.ToString();
    }

    public void changeEffect(bool isLeft)
    {
        if (isLeft)
        {
            if (--currentPage < 0) currentPage = effectPrefabs.Length - 1;
        }
        else
        {
            if (++currentPage >= effectPrefabs.Length) currentPage = 0;
        }

        Destroy(currentEffect);
        currentEffect = Instantiate(effectPrefabs[currentPage], effectPoint.transform);
        name.text = effectNames[currentPage];
        detail.text = effectsDetails[currentPage];
        page.text = (currentPage + 1).ToString() + " / " + effectPrefabs.Length.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
