using UnityEngine;

public class Incubator : MonoBehaviour
{
    public Storage st;
    public int WheatCount;//сколько нужно для яйца
    public int Wheats;// сколько есть уже
    public bool isPermission = false;// есть камень или его нет
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Wheat")// МагРок это магический камень
        {
            Wheats += 1;// пополняем инкубатор
            Destroy(other.gameObject);            
        }
        if (other.tag == "MagRock" && !isPermission)// камень сам вставишь с такимже названием
        {
            
            Destroy(other.gameObject);
            isPermission = true;
        }
        if (Wheats >= WheatCount && isPermission)
        {            
            st.Eggs += 1;
            if (Wheats > WheatCount){
           		Wheats = Wheats - WheatCount;
            } else {

            	Wheats = 0;
            }
            isPermission = false;
        }
    }
}