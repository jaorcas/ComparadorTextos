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

        using (StreamReader leer = new StreamReader(@"C:\locale_game.txt",System.Text.Encoding.UTF8)){                 //ASIGNAMOS DONDE ESTA EL DOCUMENTO QUE QUEREMOS LEER
       
            string linea1 = null;          

            while ((linea1 = leer.ReadLine()) != null){                                  //LEE LA LINEA CORRESPONDIENTE DEL PRIMER TXT

                string[] palabras = linea1.Split('\t');                                   //SEPARAMOS LA LINEA EN PALABRAS
                bool variableRepetida = false;

                using (StreamReader leer2 = new StreamReader(@"C:\locale_game2.txt", System.Text.Encoding.GetEncoding(1252))){       //COGE ESA LÍNEA Y RECORRE EL SEGUNDO TXT

                    string linea2 = null;

                    while ((linea2 = leer2.ReadLine()) != null)
                    {                          //LEE LA LINEA CORRESPONDIENTE DEL SEGUNDO TXT

                        string[] palabras2 = linea2.Split('\t');


                        if (palabras[0] == palabras2[0])
                        {

                            File.AppendAllText(@"C:\prueba3.txt", linea2 + "\r\n");     //SI LA LINEA DEL PRIMER TXT Y ALGUNA DEL SEGUNDO TXT COINCIDEN, LA ESCRIBE
                            variableRepetida = true;

                        }

                    }

                }

                if (!variableRepetida) {                                               //SI NO HA ENCONTRADO NINGUNA VARIABLE IGUAL, LA AÑADE

                    File.AppendAllText(@"C:\prueba3.txt", linea1 + "\r\n");
                    File.AppendAllText(@"C:\prueba4.txt", linea1 + "\r\n");

                }
                

            }

        }
    }
}
