using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffTutorial : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject spell;
    public bool firing = false;

    // Start is called before the first frame update
    void Start()
    {
        spell = Resources.Load("WaterSpell") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !firing)
        {
            StartCoroutine(Fire());
        }
    }

    public IEnumerator Fire()
    {
        firing = true;
        Instantiate(spell, firePoint.transform.position, firePoint.transform.rotation);
        yield return new WaitForSeconds(1.5f);
        firing = false;
    }
}
