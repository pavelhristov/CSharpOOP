namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions.Abstract
{
   using Common.Enums;
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Tunnings.Abstract;

   class Transmission:TunningPart, ITransmission, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
   {

      public Transmission(decimal price, int weight, int acceleration, int topSpeed, TunningGradeType gradeType, TransmissionType transmissionType)
         : base(price, weight, acceleration, topSpeed, gradeType)
      {
      this.TransmissionType = transmissionType;
   }

   public TransmissionType TransmissionType { get; private set; }
}
}