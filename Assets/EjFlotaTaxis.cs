using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjFlotaTaxis : MonoBehaviour
{
    public int cantidaddetaxis;
    public int cantidadtotaldedias;
    public int diasdelluvia;

    // Start is called before the first frame update
    void Start()
    {
        float costototalcombustible;
        int kilometrostotalesdianormal;
        int kilometrostotaldiaslluvia;
        int cantidadtotaldediasengeneral;
        int preciodenaftadianormal;
        float preciodenaftadialluvia;
        float litropordialluvia;


        litropordialluvia = 110 / 15;

        kilometrostotalesdianormal = cantidadtotaldedias * 90 * cantidaddetaxis;
        kilometrostotaldiaslluvia = diasdelluvia * 110 * cantidaddetaxis;
        cantidadtotaldediasengeneral = cantidadtotaldedias + diasdelluvia;
        preciodenaftadianormal = kilometrostotalesdianormal * 130;
        preciodenaftadialluvia = kilometrostotaldiaslluvia * litropordialluvia * 130;
        costototalcombustible = preciodenaftadialluvia + preciodenaftadialluvia;

        if (cantidadtotaldediasengeneral < 5)

        {
            Debug.Log("ERROR");
        }
            
        else if (diasdelluvia < 0)
        {
            Debug.Log("ERROR");
        }

        else if (diasdelluvia > cantidadtotaldedias)
        {
            Debug.Log("ERROR");
        }

        else
        {

            Debug.Log("Una flota de " + cantidaddetaxis + " unidades trabajando durante " + cantidadtotaldediasengeneral + " dias implicará un gasto de " + costototalcombustible + " pesos en concepto de combustible ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
