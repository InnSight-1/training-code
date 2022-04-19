﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonDL;
using PokemonModels;
namespace PokemonUI
{
    internal class AddPokemonMenu : IMenu
    {
        private static Pokemon newPokemon = new Pokemon();
        private IRepository _repository = new Repository();
        public void Display()
        {
            Console.WriteLine("Enter Pokemon Information");
            //feel free to add more options here like for Defense, Health etc....
            Console.WriteLine("<3> Name - " + newPokemon.Name);
            Console.WriteLine("<2> Level - " + newPokemon.Level);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    _repository.AddPokemon(newPokemon);
                    return "MainMenu";
                case"2":
                    Console.Write("Please enter a level ");
                    newPokemon.Level = Convert.ToInt32(Console.ReadLine());
                    return "AddPokemon";
                case"3":
                    Console.Write("Please enter a name! ");
                    newPokemon.Name = Console.ReadLine();
                    return "AddPokemon";
                /// Add more cases for any other attributes of pokemon
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddPokemon";
            }
        }
    }
}
