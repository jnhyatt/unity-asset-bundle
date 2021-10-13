using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponLoader : MonoBehaviour
{
    void Start()
    {
        Resources.LoadAll<Weapon>("Weapons").ToList().ForEach(x => Instantiate(x.gameObject));
        AssetBundle.LoadFromFile(Application.dataPath + "/Weapons/mod").LoadAllAssets<GameObject>().ToList().ConvertAll(x => x.GetComponent<Weapon>())
            .ForEach(x => Instantiate(x.gameObject));
    }
}