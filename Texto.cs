using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Texto : MonoBehaviour{


    private void Start(){

        Main();
    }

    static void Main(){


        using (StreamReader leer = new StreamReader(@"C:\prueba.txt")){

            string linea1 = null;

            while ((linea1 = leer.ReadLine()) != null){                                  //LEE LA LINEA CORRESPONDIENTE DEL PRIMER TXT

                using (StreamReader leer2 = new StreamReader(@"C:\prueba2.txt")) {       //COGE ESA LÍNEA Y RECORRE EL SEGUNDO TXT

                    string linea2 = null;

                    while ((linea2 = leer2.ReadLine()) != null){

                        if (linea2 == linea1) {

                            File.AppendAllText(@"C:\prueba3.txt", linea1 + "\r\n");     //SI LA LINEA DEL PRIMER TXT Y ALGUNA DEL SEGUNDO TXT COINCIDEN, LA ESCRIBE
                        }

                    }

                }

            }

        }
    }
}
