﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }


        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public Pet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;
        }

        public int GetHunger()
        {
            return Hunger;
        }

        public int GetBoredom()
        {
            return Boredom;
        }

        public int GetHealth()
        {
            return Health;
        }

        public void Feed()
        {
            Hunger -= 40;
            Console.WriteLine("You have fed your pet.");
        }

        public void SeeDoctor()
        {
            Health += 30;
            Console.WriteLine("You have taken your pet to the doctor.");
        }

        public void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;

            Console.WriteLine("You have played with your pet.");

        }

        public void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
        }
    }
}
