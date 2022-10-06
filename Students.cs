using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L8ClassAndObj
{
    public class Students
    {
        //PROPERTIES - TRACKING PRICE, MAKE, MODEL, COLOR, YEAR

        //CONSTRUCTOR - USE TO FILL IN THE PROPERTIES

        //METHODS - NOT CURRENTLY NEEDED - WE WON'T NEED TO PERFORM AN ACTION



        //BELOW PROPERTIES - get; set; ALLOWS US TO ALTER THE PROPERTIES AS THE CLASS IS RUNNING
        public string Student { get; set; }
        public int StudentAge { get; set; }

        //public string Color { get; set; }
        //public int Year { get; set; }
        //public double MilesTraveled { get; set; }


        //THIS IS A CONSTRUCTOR - CONSTRUCTORS ARE METHODS WITHOUT A RETURN TYPE OR "STATIC" IN THE SIGNATURE
        //CONSTRUCTOR BUILDS AND RETURNS AN INSTANCE(OBJECT) OF THE MATCHING CLASS
        //IN ORDER TO TELL C# I AM MAKING A CAR CONSTRUCTOR - THE CONSTRUCTOR NAME IN THE SIGNATURE must MATCH THE NAME OF THE CLASS.
        public Students(string Student, int StudentAge)
        //WHEN PARAMETERS ARE LISTED IN THE CONSTRUCTOR I AM REQUIRING THESE INPUTS FOR THIS OBJECT
        //WHEN THE PARAMETER MATCHES THE PROPERTY NAME, 
        {
            //USING "this.Property" GIVES OUR PROPERTY THE INITIALIZED DATA ON THE RIGHT OF THE EQUALS
            this.Student = Student;
            this.StudentAge = StudentAge;
            //this.Color = Color;
            //this.Year = Year;
        }

        /*//PRACTICING METHODS WITH CLASSES - NOTICE THE METHOD IN THE CLASS LACKS "static"
        public void Drive()
        {
            MilesTraveled++;
        }*/
    }
}
