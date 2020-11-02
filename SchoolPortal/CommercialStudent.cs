using System;

namespace SchoolPortal
{
    public class CommercialStudent : Student
    {
      private int electronicCircuitsScore; 
      private int circuitAnalysisScore;
      private int AnalogCommunicationsScore;
      
      

      public CommercialStudent(string studentname, string studentregnumber, int electronicCircuits, int circuitanalysis, int analogcommunications):base(studentname, studentregnumber)
      {
          ElectronicCircuitsScore = electronicCircuits;
          CircuitAnalysisScore = circuitanalysis;
          AnalogCommunicationsScore = analogcommunications;
      }


    public int ElectronicCircuitsScore
    {
        get{return electronicCircuitsScore; }

        private set
        {
            if(value >= 0 && value <= 100)
            {
                electronicCircuitsScore = value;
            }
        }
    }

    public int CircuitAnalysisScore
    {
        get{return circuitAnalysisScore; }

        private set
        {
            if(value >= 0 && value <= 100)
            {
                circuitAnalysisScore = value;
            }
        }
    }

     public int analogCommunicationsScore
    {
        get{return analogCommunicationsScore; }

        private set
        {
            if(value >= 0 && value <= 100)
            {
                analogCommunicationsScore = value;
            }
        }
    }

    public override string ToString()
    {
        int Average = (ElectronicCircuitsScore + CircuitAnalysisScore + AnalogCommunicationsScore)/3;
        
        return $"Student Name: {StudentName}\nStudent Registration: {StudentRegNumber}\nElectronic Circuits: {electronicCircuitsScore}\nCircuit Analysis: {CircuitAnalysisScore}\nAnalog Communications: {AnalogCommunicationsScore}\nAverage: {Average}";
    }
    
      
    }
}
