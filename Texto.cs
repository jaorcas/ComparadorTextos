using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Texto : MonoBehaviour {


    private void Start() {

        Main();
    }

    static void Main() {


        using (StreamReader read = new StreamReader(@"C:\prueba.txt")) {

            string line = null;

            while ((line=read.ReadLine() )!= null) {

                File.AppendAllText(@"C:\prueba3.txt", line + "\r\n");

                //hola

            }         

        }

    }
    
}
