namespace Societies.Core.Models.Humans.Abstract
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Infrastructure.Enumerations.Human;
   using Common;
   using Infrastructure.Utils;
   using Infrastructure.Constants;
   public abstract class Human : IHuman
   {
      private readonly string name;
      private readonly int age;
      private readonly HairColorType hairColor;
      private readonly EyesColorType eyesColor;
      private readonly FaceShapeType faceShape;
      private readonly RaceType race;
      private readonly GenderType gender;
      private readonly ReligionType religion;
      private decimal moneyInEuro;
      private int starvationLevel;
      private int thirstLevel;
      private int vitalityLevel;

      private Human()
      {
         this.starvationLevel = ValidationConstants.StarvationLevelMaxValue;
         this.thirstLevel = ValidationConstants.ThirstLevelMaxValue;
         this.vitalityLevel = ValidationConstants.VitalityLevelMaxValue;
         this.moneyInEuro = ValidationConstants.MoneyInEuroMaxValue;

      }
      public Human(
         string name,
         int age,
         HairColorType hairColor,
         EyesColorType eyesColor,
         FaceShapeType faceShape,
         RaceType race,
         GenderType gender,
         ReligionType religion,
         decimal moneyInEuro):this()
      {
         this.Id = DataGenerator.GenerateUniqueId();
         this.name = name;
         this.age = age;
         this.hairColor = hairColor;
         this.eyesColor = eyesColor;
         this.faceShape = faceShape;
         this.gender = gender;
         this.race = race;
         this.religion = religion;
      }

      //TODO validate getters 
      public int Age { get; }

      public EyesColorType EyesColor { get; }

      public FaceShapeType FaceShape { get; }

      public GenderType Gender { get; }

      public HairColorType HairColor { get; }

      public int Id { get; private set; }

      public decimal MoneyInEuro { get; }

      public string Name { get; }

      public RaceType Race { get; }

      public ReligionType Religion { get; }

      public int StarvationLevel { get; }

      public int ThirstLevel { get; }

      public int VitalityLevel { get; }

      public void Drink(Beverage beverage)
      {
         throw new NotImplementedException();
      }

      public void Eat(Food food)
      {
         throw new NotImplementedException();
      }

      public void Rest(int minutes)
      {
         throw new NotImplementedException();
      }

      public void Sleep(int hours)
      {
         throw new NotImplementedException();
      }

      public void Work(int hours)
      {
         throw new NotImplementedException();
      }
      //public virtual decimal Pay(decimal amountToBePayed)
      //{

      //}
      public override string ToString()
      {
         StringBuilder builder = new StringBuilder();

         builder.Append($"ID: {this.Id}");
         builder.Append($"Name: {this.name}");
         builder.Append($"Age: {this.age}");
         builder.Append($"Vitality Level: {this.vitalityLevel}/{ValidationConstants.VitalityLevelMaxValue}");
         builder.Append($"Starvation Level: {this.starvationLevel}/{ValidationConstants.StarvationLevelMaxValue}");
         builder.Append($"Thirst Level: {this.thirstLevel}/{ValidationConstants.ThirstLevelMaxValue}");
         builder.Append($"Race: {this.race}");
         builder.Append($"Gender: {this.gender}");
         builder.Append($"Religion: {this.religion}");
         builder.Append($"Hair Color: {this.hairColor}");
         builder.Append($"Eyes Color: {this.eyesColor}");
         builder.Append($"Face Shape: {this.faceShape}");
         builder.Append($"Money In Euro: {this.moneyInEuro}");

         return builder.ToString();
      }
   }
}
